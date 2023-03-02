import { Injectable } from "@angular/core";
import { Stock } from "../types/stock.interface";

Injectable()

export class StockService {

    stocks!: Stock[];

    constructor() {
        this.stocks = [
            {
                id: 1,
                name: 'Stock - 1',
                code: 'ABC',
                price: 90,
                previousPrice: 85,
                exchange: 'HGHVL',
                favorite: false
            },
            {
                id: 2,
                name: 'Stock - 2',
                code: 'CBA',
                price: 105,
                previousPrice: 90,
                exchange: 'HREWQ',
                favorite: false
            },
            {
                id: 3,
                name: 'Stock - 3',
                code: 'BAC',
                price: 55,
                previousPrice: 35,
                exchange: 'LYTRH',
                favorite: false
            }
        ];
    }

    getStocks(): Stock[] {
        return this.stocks;
    }

    createStocks(stock: Stock): boolean {
        let foundStock = this.stocks.find(each => each.code === stock.code);
        if (foundStock) {
            return false;
        }
        this.stocks.push(stock);
        return true;
    }
}