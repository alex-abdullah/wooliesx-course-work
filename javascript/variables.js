// Variables

// Objectives
// How can you create variables?
// How can you change variables?
// What is the difference between let and const?
// Why do we not use var?

// What is a variable?
// Its a way for us to store values in the computer memory
// We attach a label to said value, and when we use that label's name
// It is in reference to the value it contains

let myName = "Alex";
// When we access that box by using its label
// we are actually accessing the value contained inside

// The value of a variable is often less important than what the variable represents
// (Within the context of writing code)

let itemPrice = 14.99;
const tax = 0.1;

console.log("Big price equals " + (itemPrice + itemPrice * tax));

let myVariable;
// const myConstant;
var evilVariable;

// Const
// Needs to be defined when it is declared
// Cannot change after definition

// Let
// Can be declared without definition
// Can change as much as you like

// CHALLENGE

const firstName = "Alex";
const lastName = "Abdullah";
let age = 25;

console.log(
    "Hi, my name is " +
        firstName +
        " " +
        lastName +
        " and I am " +
        age +
        " years old!"
);

// Naming conventions

// camelCase (js)
// Variables start with a lower case letter
// thisIsAnExample

// PascalCase (C#)
// ThisIsAnExample
