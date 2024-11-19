class Marker {
    constructor(color, inkAmount) {
        this.color = color;
        this.inkAmount = inkAmount;
    }

    print(text) {
        let inkUsed = 0;
        let printedText = '';

        for (let char of text) {
            if (char !== ' ') {
                if (this.inkAmount - inkUsed >= 0.5) {
                    printedText += char;
                    inkUsed += 0.5;
                } else {
                    break;
                }
            } else {
                printedText += char;
            }
        }

        this.inkAmount -= inkUsed;
        console.log(`%c${printedText}`, `color: ${this.color}`);
    }
}

class RefillableMarker extends Marker {
    refill() {
        this.inkAmount = 100;
        console.log("Маркер заправлено.");
    }
}

// Демонстрація
const simpleMarker = new Marker('blue', 10);
simpleMarker.print("Привіт, світ!");

const refillableMarker = new RefillableMarker('red', 5);
refillableMarker.print("Цей маркер можна заправляти.");
refillableMarker.refill();
refillableMarker.print("Тепер маркер знову повний.");
