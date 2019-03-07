function solve() {
    class Person {
        constructor(firstName, lastName, age, email) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.email = email;
        }

        toString() {
            return `${this.firstName} ${this.lastName} (age: ${this.age}, email: ${this.email})`;
        }
    }
    let arr = [];
    arr.push(new Person('Maria', 'Petrova', 22, 'mp@yahoo.com'));
    arr.push(new Person('SoftUni'));
    arr.push(new Person('Stephan', 'Nikolov', 25));
    arr.push(new Person('Peter', 'Kolev', 24, 'ptr@gmail.com'));

    return arr;
}