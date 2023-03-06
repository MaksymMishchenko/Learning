import { HttpClientModule } from '@angular/common/http';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { TestBed, waitForAsync, inject, ComponentFixture } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { StockService } from 'src/app/services/stock.service';
import { StockItemComponent } from '../stock-item/stock-item.component';
import { StockListComponent } from './stock-list.component';

describe('StockListComponent with real server', () => {
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
        }, 'Get stock from server').flush([{
            id: 1,
            name: 'Test Stock - 1',
            code: 'HGFDG',
            price: 52,
            previousPrice: 20,
            exchange: "YTRFDS"
        },
        {
            id: 2,
            name: 'Test Stock - 2',
            code: 'HGFTF',
            price: 20,
            previousPrice: 10,
            exchange: "WQRFDS"
        }]);
    }));

    it('should load stocks of from servece', waitForAsync(() => {
        expect(component).toBeTruthy();
        expect(component.stocks$).toBeTruthy();
        fixture.whenStable().then(() => {
            fixture.detectChanges();
            const stocksEl = fixture.debugElement.queryAll(By.css('app-stock-item'));
            expect(stocksEl.length).toEqual(2);
        });
    }));

    afterEach(() => {
        httpBackend.verify();
    })
});