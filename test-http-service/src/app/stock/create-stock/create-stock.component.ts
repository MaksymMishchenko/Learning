import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Stock } from 'src/app/model/stock';
import { StockService } from 'src/app/services/stock.service';

@Component({
    selector: 'app-create-stock',
    templateUrl: './create-stock.component.html'
})

export class CreateStockComponent implements OnInit {
    form!: FormGroup;
    stock!: Stock;
    message = '';
    constructor(private fb: FormBuilder, private stockService: StockService) { }

    ngOnInit(): void {
        this.form = this.fb.group({
            name: new FormControl('', [Validators.required]),
            code: new FormControl('', [Validators.required]),
            price: new FormControl('', [Validators.required]),
            exchange: new FormControl('', [Validators.required])
        });

        this.initializeStock();
    }

    initializeStock() {
        this.stock = {
            id: 0,
            name: '',
            code: '',
            price: 0,
            previousPrice: 0,
            exchange: '',
            favorite: false
        };
    }

    onSubmit() {
        if (this.form.valid) {
            this.stock = {
                id: 6,
                name: this.form.value.name,
                code: this.form.value.code,
                price: this.form.value.price,
                previousPrice: 0,
                exchange: this.form.value.exchange,
                favorite: false
            };
            this.stockService.createStock(this.stock).subscribe((result: any) => {
                this.message = 'was added';
                this.initializeStock();
            }, (err) => {
                this.message = 'Stock already exist';
            })
        } else {
            console.error('Form is in invalid form')
        }
    }
}