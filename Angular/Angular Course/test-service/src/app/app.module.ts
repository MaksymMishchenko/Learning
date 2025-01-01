import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { StockService } from './services/stockService.service';
import { CreateStockComponent } from './stock/create-stock/create-stock.component';
import { StockItemComponent } from './stock/stock-item/stock-item.component';
import { StockListComponent } from './stock/stock-list/stock-list.component';


@NgModule({
  declarations: [
    AppComponent,
    StockListComponent,
    StockItemComponent,
    CreateStockComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule
  ],
  providers: [StockService],
  bootstrap: [AppComponent]
})
export class AppModule { }
