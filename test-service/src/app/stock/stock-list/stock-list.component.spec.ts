import { ComponentFixture, TestBed, waitForAsync } from "@angular/core/testing";
import { StockService } from "src/app/services/stockService.service";
import { StockItemComponent } from "../stock-item/stock-item.component";
import { StockListComponent } from "./stock-list.component"

describe('Test StockList component with Fake Service', () => {
    let component: StockListComponent;
    let fixture: ComponentFixture<StockListComponent>

    beforeEach(waitForAsync(() => {
        let stockServiceFake = {
            getStocks: () => {
                return [{ id: 0, name: 'Test', code: 'GFD', price: 50, previousPrice: 45, exchange: 'HGFEE', favorite: false }]
            }
        };
        TestBed.configureTestingModule({
            declarations:[StockListComponent, StockItemComponent],
            providers: [{
                provide: StockService,
                useValue: stockServiceFake
            }]

        }).compileComponents();
    }));

    beforeEach(() => {
        fixture = TestBed.createComponent(StockListComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });

    it('should load stocks from fake service on init', () => {
        expect(component).toBeTruthy();
        expect(component.stocks.length).toEqual(1);
        expect(component.stocks[0].code).toEqual('GFD');
    });
});