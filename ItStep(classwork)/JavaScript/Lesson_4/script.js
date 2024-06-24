'use strict'

// const user = {
//     name: "illia",
//     print: function() {
//         console.log(`Hello ${this.name}`);
//     }
// };
//
// user.print();

// const date = new Date();
// console.dir(date);

// const Person = function(firstName, lastName, email, phoneNumber) {
//     this.firstName = firstName;
//     this.lastName = lastName;
//     this.email = email;
//     this.phoneNumber = phoneNumber;
// }
//
// Person.prototype.print = function() {
//     console.log(`Hello, ${this.lastName}`);
// }
//
// let person = new Person("Illia", "Hryshchenko", "@gmail.com", "01");
// console.dir(person);

// class Person {
//     constructor(name, age = 19) {
//         this.name = name;
//         this.age = age;
//     }
//
//     toString() {
//         return `${this.name}: ${this.age}`;
//     }
// }
//
// let p = new Person('Illia');
// console.log(p.toString());

// class Rectangle {
//     constructor(width, height = width) {
//         this.width = width;
//         this.height = height;
//     }
//
//     get gender() {
//         return this.#gender;
//     }
//
//     getPerimeter() {
//         return (this.width + this.height) * 2;
//     }
//     getArea() {
//         return this.width * this.height;
//     }
// }
//
// let rect = new Rectangle(10);
// console.log(rect.getPerimeter());
// console.log(rect.getArea());

// class Person {
//     constructor(name, age = 19) {
//         this.name = name;
//         this.age = age;
//     }
//
//     print() {
//         console.log(`Hello, ${this.name}`);
//     }
//
//     toString() {
//         return `${this.name}: ${this.age}`;
//     }
// }
//
// class Student extends Person {
//     constructor(name, age = 19, course) {
//         super(name, age);
//         this.course = course;
//     }
//
//     print() {
//         console.log(`Student ${this.name} studying on: ${this.course}`);
//     }
//
//     toString() {
//         return super.toString() + `, {${this.course}}`;
//     }
// }
//
// class Teacher extends Person {
//     constructor(name, age = 19, skills) {
//         super(name, age);
//         this.skills = skills;
//     }
//
//     print() {
//         console.log(`Teacher ${this.name} has skills: ${this.skills}`);
//     }
// }
//
// let person = new Person("John", 25);
// let student = new Student("illia", 17, ["Frontend", "Backend"]);
// let teacher = new Teacher("wow", 30, ["Frontend", "Backend"]);

class Figure {
    constructor(width, height = width) {
        this.width = width;
        this.height = height;
    }
}

class Rectangle extends Figure {
    constructor(width, height) {
        super(width, height);
    }

    getPerimeter() {
        return (this.width + this.height) * 2;
    }

    getArea() {
        return this.width * this.height;
    }
}

class Circle extends Figure {
    constructor(width) {
        super(width);
        this.radius = width / 2;
    }

    getPerimeter() {
        return Math.PI * this.width;
    }

    getArea() {
        return 2 * Math.PI * this.width;
    }
}

class Triangle extends Figure {
    constructor(width, height) {
        super(width, height);
    }

    getPerimeter() {
        return this.width + this.height + Math.sqrt(this.width ^ 2 + this.height ^ 2);
    }

    getArea() {
        this.width * this.height / 2;
    }
}

let rect = new Rectangle(10);
let circle = new Circle(5);
let triangle = new Triangle(10, 5);

console.log('RECT:\n');
console.log(rect.getPerimeter());
console.log(rect.getArea());

console.log('CIRCLE:\n');
console.log(circle.getPerimeter());
console.log(circle.getArea());

console.log('TRIANGLE:\n');
console.log(triangle.getPerimeter());
console.log(triangle.getArea());