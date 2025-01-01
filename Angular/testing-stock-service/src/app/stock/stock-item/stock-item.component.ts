import { Component, Input } from "@angular/core";
import { Stock } from "src/app/model/stock.interface";

@Component({
    selector: 'app-stock-item',
    templateUrl: './stock-item.component.html',
    styles: [`
    .container {
        display: inline-block;
        margin: 1rem;
    }
    `]
})

export class StockItemComponent{
    @Input() stock!: Stock
}