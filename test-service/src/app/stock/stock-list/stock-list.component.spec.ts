import { ComponentFixture, TestBed, waitForAsync } from "@angular/core/testing"
import { StockService } from "src/app/services/stockService.service"
import { Stock } from "src/app/types/stock.interface";
import { StockItemComponent } from "../stock-item/stock-item.component"
import { StockListComponent } from "./stock-list.component"

describe('Testing StockListComponent', () => {
    let component: StockListComponent
    let fixture: ComponentFixture<StockListComponent>
    let fakeStockService = {
        getStocks: () => {
            return [{ id: 1, name: 'Test', code: 'GFD', price: 45, previousPrice: 85, exchange: 'GFDSDD', favorite: false }];
        }
    };

    beforeEach(waitForAsync(() => {
        TestBed.configureTestingModule({
            declarations: [StockListComponent, StockItemComponent],
            providers: [{
                provide: StockService,
                useValue: fakeStockService
            }]
        }).compileComponents();
    }));

    beforeEach(() => {
        fixture = TestBed.createComponent(StockListComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });

    it('should load stocks from fake service', () => {
        expect(component).toBeTruthy();
        expect(component.stocks.length).toEqual(1);
        expect(component.stocks[0].code).toEqual('GFD');
    });
});