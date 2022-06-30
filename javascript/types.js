console.log("Hey");

// atom one dark

// script tag should go in the head section
// <script scr="myFile.js"></script>

// console.log("Hey");
// console is an object
// log is a function of the console object
// whenever we use a function, we require brackets
// with console.log, it will log the value of anything that is inside of the brackets
// that value is the argument
// if you want to log some text, use "quotation marks" otherwise it will think you have a variable named whatver and will try to log the value of that variable

// different types of brackets and their purposes

// () called braces, parentheses, or 'round brackets' -> These are used for calling a function. You put the arguments for a function inside the bracket

// [] square brackets, used for accessing the values inside arrays and sometimes objects

// {} braces or 'curly brackets'
// used to separate different code blocks from one another
// code blocks define the layout and structure of the code in our files
// can be used to define objects

// <> 'angle brackets'
// we use these in C#, don't worry

// Types

// What is data?
// Variable
// Value

// A variable is a 'placeholder' for data
// the value is the data for a variable
// a value is data

// What is a type?
// a handful of different possible formats

// Here are our types:
// Numbers

// Strings
// Strings are a series of characters
// These are typically human readable
console.log(typeof "Hey");

// Boolean
console.log(typeof true);
console.log(typeof false);

// Undefined
console.log(typeof undefined);

// object

console.log(typeof console);
let myNewArray = [];
console.log(typeof myNewArray);

// function

console.log(typeof console.log);

// Typeof Challenge
console.log(typeof 15); // number
console.log(typeof 5.5); // number
console.log(typeof NaN); // number
console.log(typeof "hello"); // String
console.log(typeof true); // boolean
console.log(typeof 1 != 2); // boolean
console.log(typeof "hamburger" + "s"); // string
console.log(typeof 1 + 1 + 2); // number2
console.log(typeof "hamburgers" - "s"); // NaN
console.log(typeof "1" - "3"); // NaN
console.log(typeof ("1" - "3")); // number

// using the + operator
// As soon as a string gets involved, everything becomes strings

// Using any other operator
// It will all become numbers, will most likely result in a nan
