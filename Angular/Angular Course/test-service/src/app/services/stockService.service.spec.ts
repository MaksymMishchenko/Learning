import { TestBed, inject } from '@angular/core/testing';
import { StockService } from './stockService.service';

describe('Testing StockService', () => {
    let stockService: StockService;
    beforeEach(() => {
        TestBed.configureTestingModule({
            providers: [StockService]
        });
    });

    beforeEach(inject([StockService], (service: StockService) => {
        stockService = service;
    }));

    it('should create stock instance', () => {
        expect(stockService).toBeTruthy();
    });

    it('should load stocks from StockService', () => {
        expect(stockService.getStocks().length).toEqual(3);
        expect(stockService.getStocks()[0].code).toEqual('ABC');
        expect(stockService.getStocks()[1].code).toEqual('CBA');
        expect(stockService.getStocks()[2].code).toEqual('BAC');
    });

    it('should add stock to stocks', () => {
        expect(stockService).toBeTruthy();
        const stock = { id: 1, name: 'Test', code: 'HGFDE', price: 50, previousPrice: 45, exchange: 'HGD', favorite: false };
        expect(stockService.createStocks(stock)).toBeTruthy();
        expect(stockService.getStocks()[3].code).toEqual('HGFDE');
    })
});