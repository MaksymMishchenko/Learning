import { ComponentFixture, TestBed, waitForAsync, inject } from "@angular/core/testing";
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing'
import { CreateStockComponent } from "./create-stock.component"
import { StockItemComponent } from "../stock-item/stock-item.component";
import { StockListComponent } from "../stock-list/stock-list.component";
import { StockService } from "src/app/services/stock.service";
import { HttpClientModule } from "@angular/common/http";
import { By } from "@angular/platform-browser";

describe('CreateStockComponent With Real Service', () => {
    let component: CreateStockComponent;
    let fixture: ComponentFixture<CreateStockComponent>;
    let httpBackend: HttpTestingController;

    beforeEach(waitForAsync(() => {
        TestBed.configureTestingModule({
            declarations: [StockListComponent, StockItemComponent, CreateStockComponent],
            providers: [StockService],
            imports: [HttpClientModule, HttpClientTestingModule]
        }).compileComponents();
    }));

    beforeEach(inject([HttpTestingController], (backend: HttpTestingController) => {
        httpBackend = backend;
        fixture = TestBed.createComponent(CreateStockComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    }));

    it('should make call to create stock and handle failure',
        waitForAsync(() => {
            expect(component).toBeTruthy();
            fixture.detectChanges();

            component.stock = {
                id: 1,
                name: "Test Stock",
                code: "TSS",
                price: 200,
                previousPrice: 500,
                exchange: "NYSE",
                favorite: false
            };

            component.form.setValue(component.stock);
            expect(component.form.valid).toBeTruthy();
            component.onSubmit();

            let httpReq = httpBackend.expectOne({
                url: 'http://localhost:3000/stocks',
                method: 'POST'
            }, 'Create Stock with Failure');

            expect(httpReq.request.body).toEqual(component.stock);
            httpReq.flush({ msg: 'Stock already exist.'}, {status: 400, statusText: 'Failed!!'});

            fixture.whenStable().then(() => {
                fixture.detectChanges();
                const messageEl = fixture.debugElement.query(By.css('.message')).nativeElement;
                expect(messageEl.textContent).toEqual('Stock already exist.');
            });
        }));

    afterEach(() => {
        httpBackend.verify();
    });
});