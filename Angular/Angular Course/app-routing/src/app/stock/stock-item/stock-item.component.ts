import { Component, Input } from "@angular/core";
import { Stock } from "src/app/model/stock.interface";
import { StockService } from "src/app/services/stock.service";

@Component({
    selector: 'app-stock-item',
    templateUrl: './stock-item.component.html',
    styles: [`
    .stock-container {
    border: 1px solid black;
    border-radius: 5px;
    display: inline-block;
    padding: 10px;
    }
   .positive { color: green; }
   .negative { color: red; }
    `]
})

export class StockItemComponent {
    @Input() stock!: Stock;

    constructor(private stockService: StockService) { }

    onToggleFavorite(event: any) {
        this.stockService.toggleFavorite(this.stock).subscribe((stock) => {
            this.stock.favorite = !this.stock.favorite
        });
    }
}