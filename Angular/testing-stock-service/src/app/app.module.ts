import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { ReactiveFormsModule } from '@angular/forms';
import { CreateStockComponent } from './stock/create-stock.component.ts/create-stock.component';
import { StockService } from './services/stock.service';
import { StockListComponent } from './stock/stock-list/stock-list.component';
import { StockItemComponent } from './stock/stock-item/stock-item.component';

@NgModule({
  declarations: [
    AppComponent,
    CreateStockComponent,
    StockListComponent,
    StockItemComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [StockService],
  bootstrap: [AppComponent]
})
export class AppModule { }
