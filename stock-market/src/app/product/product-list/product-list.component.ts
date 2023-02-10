import { Component, Input, OnInit, } from "@angular/core";
import { isFavoriteProduct } from "src/app/model/is-favorite";
import { Product } from "src/app/model/product";
import { ProductQuantityChange } from "src/app/model/product-quantity-change";

@Component({
    selector: 'app-product-list',
    template: `
    <app-product [productList] = 'product'  (onchangesQuantityInCart) = quantityChange($event) (onFavorite) = isFavorite($event)
    *ngFor="let product of productList"
    ></app-product>
    `,
    styleUrls: []
})

export class ProductListComponent implements OnInit {

    productList!: Array<Product>;

    ngOnInit(): void {
        this.productList = [
            {
                id: 1,
                isOnSale: true,
                isFavorite: false,
                name: 'Elephant',
                imageUrl: 'assets/elephant.jpg',
                price: 50,
                productQuantity: 0
            },
            {
                id: 2,
                isOnSale: false,
                isFavorite: false,
                name: 'Pig',
                imageUrl: 'assets/pig.jpg',
                price: 150,
                productQuantity: 0
            },
            {
                id: 3,
                isOnSale: true,
                isFavorite: false,
                name: 'Bear',
                imageUrl: 'assets/bear.jpg',
                price: 250,
                productQuantity: 0
            },
            {
                id: 4,
                isOnSale: false,
                isFavorite: false,
                name: 'Mouse',
                imageUrl: 'assets/mouse.jpg',
                price: 350,
                productQuantity: 0
            }
        ]
    }

    quantityChange(change: ProductQuantityChange) {
        const product = this.productList.find(prod => {
            return change.product.id === prod.id;
        })
        product!.productQuantity += change.changeInQuantity;
    }

    isFavorite(favoriteProduct: isFavoriteProduct) {
        const favProduct = this.productList.find(prod => {
            return favoriteProduct.product.id === prod.id
        })
        favProduct!.isFavorite = favoriteProduct.isFavorite;
    }
}