import { ChangeDetectionStrategy, Component, Input } from '@angular/core';
import { Product } from 'src/app/model/product';

@Component({
  selector: 'app-product',
  template: `
  <div class="container" *ngFor="let product of productList; index as i" [class]="product.onSale() ? 'onSale' : 'notOnSale'">
    <img [src]="product.imageUrl" width="200px" height="200px">
    <div class="name">{{product.name}}</div>
    <div class="price">{{product.price}}</div>

    <button (click)="product.decrease()" [disabled]="product.count === 0">-</button>
    <small>{{product.count}}</small>
    <button (click)="product.increase()">+</button>
    <button (click)="product.favorite()" [disabled]="product.isFavorite">Favorite</button>
</div>
  `,
  styles: [`
  .container {
    display: inline-block;
    border: 1px solid #000;
    border-radius: 0.5em;
    padding: 1.5em;
    margin: .2em;
}

.container.name {
    font-size: 1rem;
    text-transform: uppercase;
    color: #222;
}

.onSale {
    background-color: green;
}

.notOnSale {
    background-color: red;
}
  `],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ProductComponent {

  @Input() public productList!: Array<Product>;

}
