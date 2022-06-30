// Complex Data

// A variable can contain a value
// or a reference

// When you store a number or a string in a variable, it stores the value inside that variable

const aString = "My String"; // this is a value
const faveNumber = 31; // this is a value

// this is not the case with objects (and arrays which are also objects)
// objects exist in memory
// variables cannot contain a whole object
// INSTEAD they store a reference to the object

// Objects key challenge:
// Challenge
// Write a function named fill that takes in an object and a string
// The function creates a copy of the object
// And adds the string (which is a beverage) to the object
// as a new contents key
// The function should then log "The mug is now full of tea"
// Bonus: If your object does not have a capacity key
//   It is not a watertight vessel and you should NOT add the beverage
// Bonus bonus: If your object already contains a beverage
//   It should first console log "Pouring out existing tea"

const fill = (object, string) => {
    if (!object.capacity) {
        console.log("Could not add liquid, object is not a container");
        return object;
    }

    if (object.contents) {
        console.log(`Pouring out existing ${object.contents}`);
    }

    const copy = { ...object };
    copy.contents = string;
    console.log(`The ${object.type} is now full of ${copy.contents}`);
    return copy;
};

const mug = { colour: "white", capacity: 300, waterTight: true, type: "mug" };
const mugString = "coke";

console.log(fill(mug, mugString));

// Complex data

// Objects containing arrays
const book = {
    title: "Catch 22",
    author: "Joe H",
    genre: ["War", "Comedy"],
};

// Arrays containing objects

const books = [];
books.push(book);
