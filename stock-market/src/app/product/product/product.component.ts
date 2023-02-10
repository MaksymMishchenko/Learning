import { ChangeDetectionStrategy, Component, EventEmitter, Input, Output } from '@angular/core';
import { isFavoriteProduct } from 'src/app/model/is-favorite';
import { Product } from 'src/app/model/product';
import { ProductQuantityChange } from 'src/app/model/product-quantity-change';

@Component({
  selector: 'app-product',
  template: `
  <div class="container" [class]="productList.isOnSale ? 'onSale' : 'notOnSale'">
    <img [src]="productList.imageUrl" width="200px" height="200px">
    <div class="name">{{productList.name}}</div>
    <div class="price">{{productList.price}}</div>

    <button (click)="decrease()" [disabled]="productList.productQuantity === 0">-</button>
    <small>{{productList.productQuantity}}</small>
    <button (click)="increase()">+</button>
    <button (click)="isFavorite()" [disabled]="productList.isFavorite">Favorite</button>
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

  @Input() public productList!: Product;
  @Output() private onchangesQuantityInCart = new EventEmitter<ProductQuantityChange>();
  @Output() private onFavorite = new EventEmitter<isFavoriteProduct>();

  increase() {
    this.onchangesQuantityInCart.emit({ product: this.productList, changeInQuantity: 1 });
  }

  decrease() {
    this.onchangesQuantityInCart.emit({ product: this.productList, changeInQuantity: -1 });
  }

  isFavorite() {
    this.onFavorite.emit({ product: this.productList, isFavorite: true })
  }
}
