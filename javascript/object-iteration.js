// Object iteration

// What is object iteration
// Ways that we can treat an object like an array

// const car = {
//     wheels: 4,
//     doors: 2,
//     make: "Toyota",
//     model: "Celica",
//     colour: "red",
//     isConvertible: false,
// };

function Car(wheels, doors, make, model, colour, isConvertible) {
    this.wheels = wheels;
    this.doors = doors;
    this.make = make;
    this.model = model;
    this.colour = colour;
    this.isConvertible = isConvertible;
}

const car1 = new Car(4, 2, "Toyota", "Camry", "Silver", false);

Car.prototype.toString = function () {
    return `Model: ${this.make} ${this.model} in ${this.colour}`;
};

console.log(car1.toString());
console.log(Object.keys(car1));

// instance methods
// static methods

console.log(Object.entries(car1));

// keys
// values
// entries

const isDataComplete = (object) => {
    if (Object.keys(object).length < 7) return false;
    return true;
};
