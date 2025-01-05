import { Component, OnInit } from '@angular/core';
import { Product } from './model/product';

@Component({
  selector: 'app-root',
  template: `
  <div style="text-align:center;">
  <h1>Welcome to {{title}}</h1>
  <app-product-list></app-product-list>
  </div>
  `,
  styleUrls: []
})
export class AppComponent {
  title = 'Stock Market';
}
