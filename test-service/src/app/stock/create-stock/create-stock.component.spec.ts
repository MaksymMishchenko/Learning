import { ComponentFixture, waitForAsync, TestBed } from "@angular/core/testing";
import { ReactiveFormsModule } from "@angular/forms";
import { By } from "@angular/platform-browser";
import { StockService } from "src/app/services/stockService.service";
import { CreateStockComponent } from "./create-stock.component";

describe('CreateStockComponent', () => {
    let component: CreateStockComponent;
    let fixture: ComponentFixture<CreateStockComponent>

    beforeEach(waitForAsync(() => {
        TestBed.configureTestingModule({
            declarations: [CreateStockComponent],
            providers: [StockService],
            imports: [ReactiveFormsModule]
        }).compileComponents();
    }));

    beforeEach(() => {
        fixture = TestBed.createComponent(CreateStockComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });

    it('should create stock through service', waitForAsync(() => {
        expect(component).toBeTruthy();

        component.form.setValue({
            name: 'Test',
            code: 'GFD',
            price: 45,
            previousPrice: 85,
            exchange: 'GFDSDD'
        });

        component.createStock();
        expect(component.form.valid).toBeTruthy();

        fixture.whenStable().then(() => {
            fixture.detectChanges();
            expect(component.message).toEqual('Stock with added successfully!');
            const messageEl = fixture.debugElement.query(By.css('.message')).nativeElement;
            expect(messageEl.textContent).toBe('Stock with added successfully!');
        });
    }));
});