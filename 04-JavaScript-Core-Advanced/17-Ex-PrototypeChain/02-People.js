function solve() {
    class Employee {
        constructor(name, age) {
            if (new.target === Employee) {
                throw new Error("Cannot instantiate directly");
            }
            this.name = name;
            this.age = age;
            this.salary = 0;
            this.tasks = [];
        }

        work() {
            let currentTask = this.tasks.shift();
            console.log(currentTask);
            this.tasks.push(currentTask);
        }

        collectSalary() {
            console.log(`${this.bookName} received ${this.getSalary()} this month.`)
        }

        getSalary() {
            return this.salary;
        }
    }

    class Junior extends Employee {
        constructor(name, age) {
            super(name, age);
            this.tasks.push(this.bookName + ' is working on a simple task.');
        }
    }

    class Senior extends Employee {
        constructor(name, age) {
            super(name, age);
            this.tasks.push(this.bookName + ' is working on a complicated task.');
            this.tasks.push(this.bookName + ' is taking time off work.');
            this.tasks.push(this.bookName + ' is supervising junior workers.');
        }
    }


    class Manager extends Employee{
        constructor(name, age){
            super(name, age);
            this.dividend = 0;
            this.tasks.push(this.bookName + ' scheduled a meeting.');
            this.tasks.push(this.bookName + ' is preparing a quarterly report.');
        }

        getSalary(){
            return this.salary + this.dividend;
        }
    }

    return {
        Employee,
        Junior,
        Senior,
        Manager
    }

}