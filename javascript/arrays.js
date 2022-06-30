// What are Arrays?

// A javascript way of making lists, multiple values under a single variable name

// How to create Arrays?
// literal notation
const myArray = [];
console.log(myArray);

const coaches = ["Aidan", "Calum", "Remi"];
console.log(coaches);

// Array constructor

const newArray = new Array();

console.log(newArray);

const students = new Array("Alex", "Liz", "Clint");
console.log(students);

// How to access or change elements of an array?

// Array methods
// pop - remove end
// unshift - add start
// push - add end
// shift - remove start
// includes - check if elment is in array
// indexOf - returns index of item
// join -

// Challenge: Listing Hobbies
// MVP
// Create an array with 3 of your hobbies
// Print in the console the first hobby in the array
// Remove that first hobby from the array and store that hobby in a variable
// Store the length of the array in a variable
// Add another hobby at the end of the array
// Print that last hobby in the console
// Bonus:

// Join all your hobbies in a single string each hobby being comma separated (i.e. "My hobbies are: hobby1, hobby2, hobby2")

// Challenge: Grocery Lists
// MVP
// Create an array containing 5 grocery items you often buy
// Log this list to the console, make sure the output is pipe delimited
// ['apple', 'pear', 'papaya', 'mango'] => 'apple|pear|papaya|mango'

const myHobbies = ["jumprope", "watching movies", "learning rap song lyrics"];
console.log(myHobbies[0]);

const myFaveHobby = myHobbies.shift();
console.log(myFaveHobby);

const hobbyList = myHobbies.length;
console.log(hobbyList);

myHobbies.push("working out");

lastItem = myHobbies[myHobbies.length - 1];
console.log(lastItem);

const hobbyJoin = myHobbies.join(", ");
console.log("My fave hobbies are: ", hobbyJoin);

// Challenge 2

const groceries = ["apples", "bananas", "water", "bread", "tea"];
groceriesJoin = groceries.join("|");
console.log("My grocerie list is: ", groceriesJoin);
