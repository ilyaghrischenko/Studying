'use strict'

//task 1
// let num = +prompt("Enter number(1 - 10): ");
// if (num > 10 || num < 1) alert("Invalid number");
// let sum = 0;
// for (let i = 1; i <= num; ++i) {
//     sum += i;
// }
// alert(`Sum: ${sum}`);

//task 2
// let num = +prompt("Enter number(0 - 20): ");
// if (num > 20 || num < 0) alert("Invalid number");
// for (let i = 1; i <= num; ++i) {
//     if (i % 2 == 0) console.log(i);
// }

// let userName = prompt("Name: ");
// const Hello = () => {
//     let counter = 0;

//     return test = () => {
//         counter++;
//     }
// }

// function sum() {
//     let result = 0;
//     for (let i = 0; i < arguments.length; ++i) {
//         result += arguments[i];
//     }
//     return result;
// }

// console.log(sum());
// console.log(sum(4));
// console.log(sum(4, 6, 9));
// console.log(sum(1, 2, 3, 6, 7, 4));

//task 3
// function isNumber(x) {
//     if (isNaN(x) || !isFinite(x)) return false;
//     return true;
// }

// function isValidRange(x) {
//     if (x < 1 || x > 12) return false;
//     return true;
// }

// function numberInput() {
//     let num = +prompt("Enter number(1 - 12): ");
//     if (!isNumber(num) || !isValidRange(num)) {
//         alert("Invalid number");
//         numberInput();
//     }
//     else alert(num);
// }

// numberInput();

//task 4
function isNumber(x) {
    if (isNaN(x) || !isFinite(x)) return false;
    return true;
}
function isValidRange(x) {
    if (x < 1 || x > 20) return false;
    return true;
}
function guessNumber() {
    let userInput = +prompt("Enter number(1 - 20): ");
    if (!isNumber(userInput) || !isValidRange(userInput)) {
        alert("Invalid number");
        guessNumber();
    }
    else {
        ++attempts;
        if (userInput == rndNumber) {
            alert(`Random number ${rndNumber} was guessed in ${attempts} tries`);
            return;
        }
        else if (userInput > rndNumber) alert("Too high!");
        else alert("Too low!");
        guessNumber();
    }
}

let rndNumber = Math.round(Math.random() * 20);
let attempts = 0;
guessNumber();