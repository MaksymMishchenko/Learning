import { ComponentFixture, waitForAsync, TestBed, inject } from "@angular/core/testing";
import { HttpClientTestingModule, HttpTestingController } from "@angular/common/http/testing";


import { HttpClientModule } from "@angular/common/http";
import { By } from "@angular/platform-browser";
import { StockListComponent } from "./stock-list.component";
import { StockItemComponent } from "../stock-item/stock-item.component";
import { StockService } from "src/app/services/stock.service";

describe('Fetching data to StockListComponent from Real Service', () => {
    let component: StockListComponent;
    let fixture: ComponentFixture<StockListComponent>;
    let httpBackend: HttpTestingController;

    beforeEach(waitForAsync(() => {
        TestBed.configureTestingModule({
            declarations: [StockListComponent, StockItemComponent],
            providers: [StockService],
            imports: [HttpClientModule, HttpClientTestingModule]
        }).compileComponents();
    }));

    beforeEach(inject([HttpTestingController], (backend: HttpTestingController) => {
        httpBackend = backend;
        fixture = TestBed.createComponent(StockListComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
        httpBackend.expectOne({
            url: 'http://localhost:3000/stocks',
            method: 'GET'
        }, 'Get list of stocks').flush([{
            id: 4,
            name: 'Test Stock 1',
            code: 'FDS',
            price: 50,
            previousPrice: 45,
            exchange: 'GFDSWA'
        },
        {
            id: 5,
            name: 'Test Stock 2',
            code: 'LIG',
            price: 85,
            previousPrice: 70,
            exchange: 'HTEWQ'
        }]);
    }));

    it('should load stocks from real service on init', waitForAsync(() => {
        expect(component).toBeTruthy();
        expect(component.stocks$).toBeTruthy();

        fixture.whenStable().then(()=> {
            fixture.detectChanges();
            const stockItems = fixture.debugElement.queryAll(By.css('app-stock-item'));
            expect(stockItems.length).toEqual(2);
        });
    }));
});