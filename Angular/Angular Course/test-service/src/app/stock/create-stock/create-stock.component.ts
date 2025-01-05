import { Component, OnInit } from "@angular/core";
import { FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";
import { StockService } from "src/app/services/stockService.service";
import { Stock } from "src/app/types/stock.interface";

@Component({
    selector: 'create-stock',
    templateUrl: './create-stock.component.html'
})

export class CreateStockComponent implements OnInit {
    message = '';
    form!: FormGroup;
    stock!: Stock;

    constructor(private stockService: StockService, private fb: FormBuilder) {
        this.stock = { id: 0, name: '', code: '', price: 0, previousPrice: 0, exchange: '', favorite: false };
    }

    ngOnInit(): void {
        this.form = this.fb.group({
            name: new FormControl('', [Validators.required]),
            code: new FormControl('', [Validators.required]),
            price: new FormControl(this.stock.price, [Validators.required]),
            previousPrice: new FormControl('', [Validators.required]),
            exchange: new FormControl('', [Validators.required]),
        });
    }

    createStock() {
        if (this.form.valid) {
            this.stock = this.form.value;
            this.stockService.createStocks(this.stock);
            this.message = 'Stock with added successfully!'
        }
        else {
            this.message = 'Form is in ann invalid state!'
        };
    }
}