import { TestBed, inject, ComponentFixture, waitForAsync } from '@angular/core/testing';
import { StockService } from './stockService.service';

describe('Stock Service Testing', () => {

    let stockService: StockService

    beforeEach(() => {
        TestBed.configureTestingModule({
            providers: [StockService]
        });
    });

    beforeEach(inject([StockService], (service: StockService) => {
        stockService = service;
    }));

    it('should create instance of StockService', inject([StockService], (service: StockService) => {
        expect(service).toBeTruthy();
    }));

    it('should get list of stocks', () => {
        expect(stockService.getStocks().length).toEqual(3);
        expect(stockService.getStocks()[0].code).toEqual('ABC');
        expect(stockService.getStocks()[1].code).toEqual('CBA');
        expect(stockService.getStocks()[2].code).toEqual('BAC');
    });

    it('should create new stock', () => {
        expect(stockService.getStocks().length).toEqual(3);
        const stock = {
            id: 4,
            name: 'Stock - 4',
            code: 'DBC',
            price: 200,
            previousPrice: 185,
            exchange: 'NXEWQD',
            favorite: false
        };
        expect(stockService.createStocks(stock)).toBeTruthy();
        expect(stockService.getStocks().length).toEqual(4);
        expect(stockService.getStocks()[3].code).toEqual('DBC');
    });
});