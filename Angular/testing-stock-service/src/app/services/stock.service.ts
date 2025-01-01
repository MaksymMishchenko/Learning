import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Stock } from "../model/stock.interface";

@Injectable()

export class StockService {
    constructor(private httpClient: HttpClient) { }

    getStocks(): Observable<Stock[]> {
        return this.httpClient.get<Stock[]>('http://localhost:3000/stocks');
    };

    createStock(stock: Stock): Observable<any> {
        return this.httpClient.post<Stock>('http://localhost:3000/stocks', {
            id: stock.id,
            name: stock.name
        });
    };
}