import { Component, OnInit } from "@angular/core";
import { Observable } from "rxjs";
import { Stock } from "src/app/model/stock.interface";
import { StockService } from "src/app/services/stock.service";

@Component({
    selector: 'app-stock-list',
    templateUrl: './stock-list.component.html'
})

export class StockListComponent implements OnInit {
    stocks$!: Observable<Stock[]>;

    constructor(private stockService: StockService){}

    ngOnInit(): void {
        this.stocks$ = this.stockService.getStocks();
    }
}