import { Component, Input, OnInit, } from "@angular/core";
import { Product } from "src/app/model/product";

@Component({
    selector: 'app-product-list',
    template: `
    <app-product [productList]="productList"></app-product>
    `,
    styleUrls: []
})

export class ProductListComponent implements OnInit {

    productList!: Array<Product>

    ngOnInit(): void {
        this.productList = [
            new Product('Elephant', 'assets/elephant.jpg', 50, 45, true),
            new Product('Pig', 'assets/pig.jpg', 100, 150, false),
            new Product('Bear', 'assets/bear.jpg', 50, 45, true),
            new Product('Mouse', 'assets/mouse.jpg', 50, 45, false),
        ]
    }
}