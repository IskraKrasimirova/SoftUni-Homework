class Person {
    constructor(firstName, lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    get fullName() {
        return `${this.firstName} ${this.lastName}`;
    }

    set fullName(value) {
        const [firstName, lastName] = value.split(' ');

        if (firstName && lastName) {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}


// //second decision
// function Person(firstName, lastName) {
//     this.firstName = firstName;
//     this.lastName = lastName;

//     Object.defineProperty(this, 'fullName', {
//         enumerable: true,
//         get: function () {
//             return `${this.firstName} ${this.lastName}`;
//         },
//         set: function (value) {
//             const [firstName, lastName] = value.split(' ');

//             if (firstName && lastName) {
//                 this.firstName = firstName;
//                 this.lastName = lastName;
//             }
//         }
//     });
// }


// let person = new Person("Peter", "Ivanov");
// console.log(person.fullName); //Peter Ivanov
// person.firstName = "George";
// console.log(person.fullName); //George Ivanov
// person.lastName = "Peterson";
// console.log(person.fullName); //George Peterson
// person.fullName = "Nikola Tesla";
// console.log(person.firstName); //Nikola
// console.log(person.lastName); //Tesla

let person = new Person("Albert", "Simpson");
console.log(person.fullName); //Albert Simpson
person.firstName = "Simon";
console.log(person.fullName); //Simon Simpson
person.fullName = "Peter";
console.log(person.firstName);  // Simon
console.log(person.lastName);  // Simpson

