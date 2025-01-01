import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Stock } from '../model/stock';

@Injectable()
export class StockService {

  constructor(private http: HttpClient) { }

  getStocks(): Observable<Stock[]> {
    return this.http.get<Stock[]>('http://localhost:3000/stocks');
  }

  createStock(stock: Stock): Observable<Stock> {
    return this.http.post<Stock>('http://localhost:3000/stocks', {
      id: stock.id,
      name: stock.name,
      code: stock.code,
      price: stock.price,
      previousPrice: stock.previousPrice,
      exchange: stock.exchange,
      favorite: stock.favorite
    });
  }

  toggleFavorite(stock: Stock): Observable<Stock> {
    return this.http.patch<Stock>(`http://localhost:3000/stocks/${stock.id}`, {
      favorite: !stock.favorite
    });
  }
}
