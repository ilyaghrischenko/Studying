'use strict'

class Button {
    #width = 100;
    #height = 50;

    constructor(content) {
        this.content = content;
    }

    get width() {
        return this.#width;
    }

    get height() {
        return this.#height;
    }

    print() {
        document.write(`<button style="width:${this.#width}px;height:${this.#height}px">${this.content}</button>`);
    }
}

class ColoredButton extends Button {
    constructor(content, color) {
        super(content);
        this.color = color;
    }

    print() {
        document.write(`<button style = "width: ${super.width}px; height: ${super.height}px; background-color: ${this.color};">${this.content}</button>`);
    }
}

class Product {
    constructor(name, price, count = 1) {
        this.name = name;
        this.price = price;
        this.count = count;
        this.sum = this.price * this.count;
    }

    toString() {
        return `Name: ${this.name}\nPrice: ${this.price}`;
    }
}

class Basket {
    constructor(products) {
        this.products = products;
        this.totalPrice = this.products.reduce((previous, current) => previous + current.sum, 0);
    }

    getMaxPriceProduct() {
        return this.products.reduce((maxProduct, currentProduct) =>
            currentProduct.price > (maxProduct?.price || 0) ? currentProduct : maxProduct, null);
    }

    toString() {
        const products = this.products.reduce((previous, current) => `${previous}\n${current}`, '');
        return `Products:\n[${products}\n]\nTotal price: ${this.totalPrice}\nMax price product: ${this.getMaxPriceProduct().name}\nCount: ${this.products.length}`;
    }
}

let products = [new Product('Apple', 1.0), new Product('Banana', 0.5), new Product('Orange', 2.0)];
let basket = new Basket(products);

console.log(basket.toString());