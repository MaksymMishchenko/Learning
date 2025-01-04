import { Component, OnInit } from '@angular/core';
import { StockService } from 'src/app/services/stockService.service';
import { Stock } from 'src/app/types/stock.interface';

@Component({
  selector: 'app-stock-list',
  templateUrl: './stock-list.component.html',
  styleUrls: ['./stock-list.component.scss']
})
export class StockListComponent implements OnInit {

  public stocks!: Stock[];
  constructor(private stockService: StockService) { }

  ngOnInit() {
    this.stocks = this.stockService.getStocks();
  }

  onToggleFavorite(stock: Stock) {
    console.log('Favorite for stock ', stock, ' was triggered');
    this.stockService.toggleFavorite(stock);
  }
}
