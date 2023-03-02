import { ComponentFixture, TestBed, waitForAsync } from "@angular/core/testing";
import { StockService } from "src/app/services/stockService.service";
import { StockItemComponent } from "../stock-item/stock-item.component";
import { StockListComponent } from "./stock-list.component"

describe('Test StockComponent with a Mock Service', () => {
    let component: StockListComponent;
    let fixture: ComponentFixture<StockListComponent>
    let stockService: StockService;

    beforeEach(waitForAsync(() => {
        TestBed.configureTestingModule({
            declarations: [StockListComponent, StockItemComponent],
            providers: [StockService]
        });
    }));

    beforeEach(() => {
        fixture = TestBed.createComponent(StockListComponent);
        component = fixture.componentInstance;
        stockService = fixture.debugElement.injector.get(StockService);
        let spy = spyOn(stockService, 'getStocks')
            .and.returnValue([
                {
                    id: 1, name: 'Test', code: 'FDS', price: 52, previousPrice: 85, exchange: 'JHGFD', favorite: false
                }
            ]);
        fixture.detectChanges();
    });

    it('should load stocks from mocked service on init'), () => {
        expect(component).toBeTruthy();
        expect(component.stocks.length).toEqual(1);
        expect(component.stocks[0].code).toEqual('FDS');
    };

})