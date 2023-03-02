import { ComponentFixture, TestBed, waitForAsync } from "@angular/core/testing";
import { StockService } from "src/app/services/stockService.service";
import { StockItemComponent } from "../stock-item/stock-item.component";
import { StockListComponent } from "./stock-list.component";


describe('StockListComponent with real service', () => {
    let component: StockListComponent;
    let fixture: ComponentFixture<StockListComponent>;

    beforeEach(waitForAsync(() => {
        TestBed.configureTestingModule({
            declarations: [StockListComponent, StockItemComponent],
            providers: [StockService]
        }).compileComponents();
    }));

    beforeEach(() => {
        fixture = TestBed.createComponent(StockListComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    })

    it('should load stocks from real service on init', () => {
        expect(component).toBeTruthy();
        expect(component.stocks.length).toEqual(3);
    });
});