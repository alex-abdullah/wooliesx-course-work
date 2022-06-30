// Objects

const person = {
    firstName: "Alex",
    lastName: "Abdullah",
    isAustralian: true,
    age: 25,
};

console.log(person);

// Object Methods

const student = {
    firstName: "Clint",
    city: "Sydney",
    age: 41,
    isFrench: false,

    addAge(years) {
        this.age += years;
    },

    sayHello() {
        console.log("Hello");
    },
};

console.log(student);
student.addAge(3);

console.log(student);

const coach2 = {
    name: "Aidan",
    age: 28,
    city: "Melbourne",
};

// Creating objects using a function

function Student(name, city, howOld, isFrench) {
    this.firstName = name;
    this.city = city;
    this.age = howOld;
    this.isFrench = isFrench;
}

const alex = new Student("Alex", "Sydney", "19", false);
console.log(alex);

const liz = new Student("liz", "Sydney", "19", false);
console.log(liz);

Student.prototype.greeting = function () {
    console.log(`Hello ${this.firstName}`);
};

alex.greeting();
liz.greeting();

// accessing data

console.log(alex);
console.log(alex.age);
console.log(coach2.city);

console.log(liz["city"]);

// hasOwnPropertyMethod

console.log(alex.hasOwnProperty("age"));

// modifying objects

console.log("Before change: ", alex);

alex.age = 60;
console.log(alex);

alex.isPolish = false;
console.log(alex);

// renaming a key

const city = {
    name: "Sydney",
    state: "NSW",
    population: 5,
    peoplePerSqKm: 400,
};

console.log(city);

const { state, ...otherProperties } = city;
console.log(state);

console.log(city);
