function solve(){
    class Person{
        constructor(firstName, lastName, age, email){
            this.firstName = firstName;
            this.lastName = lastName
            this.age = age
            this.email = email;
        }

        toString(){
            return `${this.firstName} ${this.lastName} (age: ${this.age}, email: ${this.email})`;
        }
    }


    function getPersons(){
        let persons = [];
        let p1 = new Person('Maria', 'Petrova', '22', 'mp@yahoo.com')
        let p2 = new Person('SoftUni', '', '', '')
        let p3 = new Person('Stephan', 'Nikolov', '25', '')
        let p4 = new Person('Peter', 'Kolev', '22', 'ptr@gmail.com')
        persons.push(p1);
        persons.push(p2);
        persons.push(p3);
        persons.push(p4);
        return persons.join('\n');
    }
}

console.log(solve())
