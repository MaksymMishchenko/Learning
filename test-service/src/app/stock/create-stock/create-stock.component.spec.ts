import { ComponentFixture, TestBed, waitForAsync, fakeAsync, tick } from "@angular/core/testing"
import { ReactiveFormsModule } from "@angular/forms"
import { By } from "@angular/platform-browser"
import { StockService } from "src/app/services/stockService.service"
import { CreateStockComponent } from "./create-stock.component"

describe('CreateStockComponent', () => {
    let component: CreateStockComponent;
    let fixture: ComponentFixture<CreateStockComponent>;
    beforeEach(waitForAsync(() => {
        TestBed.configureTestingModule({
            declarations: [CreateStockComponent],
            providers: [StockService],
            imports: [ReactiveFormsModule]
        });
    }));

    beforeEach(() => {
        fixture = TestBed.createComponent(CreateStockComponent);
        component = fixture.componentInstance;
        fixture.autoDetectChanges();
    })

    it('should add stock through the service', fakeAsync(() => {
        expect(component).toBeTruthy();
        component.form.setValue({
            name: 'Test',
            code: 'TRE',
            price: 54,
            previousPrice: 25,
            exchange: 'UYTTYU'
        });
        component.createStock();
        expect(component.form.valid).toBeTruthy();
        tick();
        fixture.detectChanges()
        expect(component.message).toEqual('Stock with added successfully!');
        const messageEl = fixture.debugElement.query(By.css('.message')).nativeElement;
        expect(messageEl.textContent).toBe('Stock with added successfully!');
    }));
});