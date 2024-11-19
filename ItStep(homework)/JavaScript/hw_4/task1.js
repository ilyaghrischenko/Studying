class PrintMachine {
    constructor(fontSize, fontColor, fontFamily) {
        this.fontSize = fontSize;
        this.fontColor = fontColor;
        this.fontFamily = fontFamily;
    }

    print(text) {
        document.write(`<span style="font-size: ${this.fontSize}px; color: ${this.fontColor}; font-family: ${this.fontFamily};">${text}</span>`);
    }
}

const printMachine = new PrintMachine(16, 'blue', 'Arial');
printMachine.print('Hello, this is a printed message!');
