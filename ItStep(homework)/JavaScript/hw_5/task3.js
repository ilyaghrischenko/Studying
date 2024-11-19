class Employee {
    constructor(name, position, salary) {
        this.name = name;
        this.position = position;
        this.salary = salary;
    }
}

class EmpTable {
    constructor(employees) {
        this.employees = employees;
    }

    getHtml() {
        let html = `<table border="1" cellpadding="5" cellspacing="0"><thead><tr><th>Name</th><th>Position</th><th>Salary</th></tr></thead><tbody>`;

        this.employees.forEach(employee => {
            html += `<tr><td>${employee.name}</td><td>${employee.position}</td><td>${employee.salary}</td></tr>`;
        });

        html += `</tbody></table>`;
        return html;
    }
}

const employees = [
    new Employee("Іван Іванов", "Менеджер", 15000),
    new Employee("Петро Петренко", "Касир", 10000),
    new Employee("Олена Ковальчук", "Аналітик", 20000)
];

const empTable = new EmpTable(employees);
document.write(empTable.getHtml());
