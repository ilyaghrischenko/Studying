'use strict';

//task 1
const btn1 = document.getElementById('btn1');
const input1 = document.getElementById('input1');

btn1.addEventListener('click', function() {
    let letterCount = 0;
    let digitCount = 0;
    let other = 0;

    input1.value.split('').forEach(element => {
        if (element >= 'a' && element <= 'z') {
            letterCount++;
        } else if (element >= '0' && element <= '9') {
            digitCount++;
        } else {
            other++;
        }
    });
    document.getElementById('result1').innerHTML = `Count of letters: ${letterCount}, count of digits: ${digitCount}, count of other: ${other}`;
});

//task 2
const btn2 = document.getElementById('btn2');
const input2 = document.getElementById('input2');

function numberToWords(num) {
    if (num < 10 || num > 99) {
        return 'Input must be a two-digit number.';
    }

    const ones = ['нуль', 'один', 'два', 'три', 'чотири', 'п’ять', 'шість', 'сім', 'вісім', 'дев’ять'];
    const teens = ['десять', 'одинадцять', 'дванадцять', 'тринадцять', 'чотирнадцять', 'п’ятнадцять', 'шістнадцять', 'сімнадцять', 'вісімнадцять', 'дев’ятнадцять'];
    const tens = ['двадцять', 'тридцять', 'сорок', 'п’ятдесят', 'шістдесят', 'сімдесят', 'вісімдесят', 'дев’яносто'];

    if (num < 20) {
        return teens[num - 10];
    }

    const ten = Math.floor(num / 10);
    const one = num % 10;

    return tens[ten - 2] + (one ? ' ' + ones[one] : '');
}

btn2.addEventListener('click', function() {
    document.getElementById('result2').innerHTML = `${numberToWords(+input2.value)}`;
});

//task 3
const btn3 = document.getElementById('btn3');
const input3 = document.getElementById('input3');

btn3.addEventListener('click', function() {
    let result3 = '';

    input3.value.split('').forEach(element => {
        if (element >= 'A' && element <= 'Z') {
            result3 += element.toLowerCase();
        }
        else if (element >= 'a' && element <= 'z') {
            result3 += element.toUpperCase();
        } else if (element >= '0' && element <= '9') {
            result3 += '_';
        } else {
            result3 += element;
        }
    });

    document.getElementById('result3').innerHTML = result3;
});

//task 4
const btn4 = document.getElementById('btn4');
const input4 = document.getElementById('input4');

btn4.addEventListener('click', function() {
    let tokens = input4.value.split('-');
    let word2 = tokens[1][0].toUpperCase() + tokens[1].slice(1);
    let result4 = `${tokens[0]}${word2}`;
    document.getElementById('result4').innerHTML = `${result4}`;
});

//task 5
const btn5 = document.getElementById('btn5');
const input5 = document.getElementById('input5');

btn5.addEventListener('click', function() {
    let words = input5.value.split(/[\s-]+/);
    let abbreviation = '';

    words.forEach(word => {
        abbreviation += word[0].toUpperCase();
    });
    document.getElementById('result5').innerHTML = `${abbreviation}`;
});

//task 6
const btnPlus = document.getElementById('btn+');
const btn6 = document.getElementById('btn6');

let allWords = '';
btnPlus.addEventListener('click', function() {
    const input6 = document.getElementById('input6');
    allWords += input6.value;
    input6.value = '';
});

btn6.addEventListener('click', function() {
    document.getElementById('result6').innerHTML = `${allWords}`;
});

//task 7
function calculateExpression(expression) {
    expression = expression.replace(/\s+/g, '');

    let operator;
    let operands;

    if (expression.includes('+')) {
        operator = '+';
        operands = expression.split('+');
    } else if (expression.includes('-')) {
        operator = '-';
        operands = expression.split('-');
    } else if (expression.includes('*')) {
        operator = '*';
        operands = expression.split('*');
    } else if (expression.includes('/')) {
        operator = '/';
        operands = expression.split('/');
    } else {
        return "Невірний вираз";
    }

    let num1 = parseFloat(operands[0]);
    let num2 = parseFloat(operands[1]);

    let result;
    switch (operator) {
        case '+':
            result = num1 + num2;
            break;
        case '-':
            result = num1 - num2;
            break;
        case '*':
            result = num1 * num2;
            break;
        case '/':
            result = num1 / num2;
            break;
        default:
            return "Невірний оператор";
    }

    return result;
}

const btn7 = document.getElementById('btn7');
const input7 = document.getElementById('input7');

btn7.addEventListener('click', function() {
    const expression = input7.value;
    const result7 = calculateExpression(expression); 

    document.getElementById('result7').innerHTML = `${result7}`;
});

//task 8
function parseURL(url) {
    let urlObj = new URL(url);
    
    let protocol = urlObj.protocol.slice(0, -1);
    let domain = urlObj.hostname;
    let path = urlObj.pathname;

    return `протокол: ${protocol}, домен: ${domain}, шлях: ${path}`;
}

const btn8 = document.getElementById('btn8');
const input8 = document.getElementById('input8');

btn8.addEventListener('click', function() {
    const url = input8.value;
    document.getElementById('result8').innerHTML = `${parseURL(url)}`;
});

//task 9
const btn9 = document.getElementById('btn9');
const input9 = document.getElementById('input9');

btn9.addEventListener('click', function() {
    let str = input9.value;
    let result = str.split('/');
    result.forEach(element => {
        document.getElementById('result9').innerHTML += `"${element}" `;
    });
});