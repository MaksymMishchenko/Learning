import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Stock } from 'src/app/model/stock.interface';
import { StockService } from 'src/app/services/stock.service';

@Component({
    selector: 'app-stock-create',
    templateUrl: './create-stock.component.html'
})

export class CreateStockComponent implements OnInit {
    form!: FormGroup
    stock!: Stock
    message = '';

    constructor(private fb: FormBuilder, private stockService: StockService) { }
    ngOnInit(): void {
        this.form = this.fb.group({
            id: [8, Validators.required],
            name: ['', Validators.required]
        });
    }

    createStock() {
        if (this.form.valid) {
            this.stock = {
                id: 5,
                name: this.form.value.name
            };
            console.log('Stock', this.stock)
            this.stockService.createStock(this.stock).subscribe((stock) => {
                this.message = 'Stock was created'
            }, (err) => {
                this.message = 'Stock already exists.'
            })
        }
    }
}