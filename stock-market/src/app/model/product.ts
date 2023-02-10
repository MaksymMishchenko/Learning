export class Product {
  isOnSale: boolean;
  isFavorite: boolean = false;
  name: string;
  imageUrl: string;
  price: number;
  previousPrice: number
  count: number = 0

  constructor(name: string,
    imageUrl: string,
    price: number,
    previousPrice: number,
    isOnSale: boolean,) {
    this.name = name;
    this.imageUrl = imageUrl;
    this.price = price;
    this.previousPrice = previousPrice;
    this.isOnSale = isOnSale;
  }

  onSale(): boolean {
    return this.isOnSale;
  }

  increase() {
    this.count++;
  }

  decrease() {
    this.count--;
  }

  favorite(): boolean {
    return this.isFavorite = true;
  }
}
