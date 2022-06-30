// booleans

// Objectives
// What is a boolean
// What are boolean expressions
// How do we compare variables
// What kind of comparisons can we do in JS

// Booleans

// Base 2
// 0 1
// 10 11

// Base 10 numbering system
// 0 1 2 3 4 5 6 7 8 9

// The most important and common use case of boolean expressions is within control flow

// Control Flow:
// If statements
// loops
// switches

// What is a boolean expression?
// A boolean expression

// A mathematical expression
// 1+2
// It has values (1 & 2)
// It has an operator (addition +)
// It can be evaluated
// We can turn this into one value by applying the operators
// to the values in the appropriate order -> BODMAS

// A boolean expression
// 5 > 3
// It has values (1 & 2)
// It has an operator (> operator)
// and it can be evaluated
// if apply > to 5 and 3
// we get true

console.log("5 is greater than 3", 5 > 3);

// Here are some comparison operators
// comparators

console.log("5 is greater than 3", 5 > 3);
console.log("Is 5 less than 3", 5 < 3);
console.log("Is 5 greater than or equal to 3?", 5 >= 3);
console.log("Is 5 greater than 5?", 5 > 5);

// =, ==, ===

// What is the difference?
// = is the assignment operator
// a single = is saying MAKE the thing on the left become the value on the right
let myValue = 5;
console.log(myValue);

// == is the equality operator
// a double equals is ASKING the computer if they are equal
console.log("Does my value equal 5?", myValue == 5);
console.log("Does my value equal 3?", (myValue = 3));
console.log(myValue);

// === is the type sensitive equality operator
console.log("Does 3 equal 3", "3" == 3);
console.log("Does 3 equal 3", "3" === 3);

// We should use === as much as possible!
// !== is the type sensitive NOT equal operator!

// Inverse of operators
// Inverse of === is !==
console.log("equals", 5 === 5);
console.log("inverse of equals", 5 !== 5);

console.log("Less than", 5 < 3);
console.log("inverse of less than", 5 >= 3);

console.log("greater than", 5 > 3);
console.log("inverse of greater than", 5 <= 3);

// Flip a bit
// true => false
// false => true
// 0 => 1
// 1 => 0

console.log(!(5 !== 5));

// Multiple operators in boolean expressions

// boolean operators are comparsion operators
// that only work between 2 values
// && AND
// && AND
// What do they do?

// && AND
console.log("True AND true", true && true);
console.log("True AND false", true && false);
console.log("False AND false", false && false);
console.log("False AND true", false && true);

// The AND operator will only return true if both values are true

// ||
console.log("True OR true", true || true);
console.log("True OR false", true || false);
console.log("False OR false", false || false);
console.log("False OR true", false || true);

// The OR operator will always return true if either of the values is true

console.log("Do I bring an umbrella?");
let isItRaining = true;
let temperature = 17.5;
console.log(isItRaining && temperature < 14);

console.log("Do I bring an umbrella?");
// If the temperature is below 12, there is a good chance of it raining so I should bring an umbrella
// However if the temperature is above 30, I risk getting burnt and should bring an umbrella
console.log(temperature < 12);
console.log(temperature > 30);
console.log(true || false);
console.log(temperature < 12 || temperature > 30);

// Multiple operators in boolean expressions
// Follows similar logic to arithmetic expressions
// Computer Order of Operations
// Brackets
// Comparisons (<, >, ===, !==, <=, >=) left to right
// Boolean operators (&&, ||, !)

console.log(3 < 5 && 6 < 8);
// 3 < 5 -> true
// 6 < 8 -> true
// true & true -> true

console.log(3 < 5 && 6 < 4);
// 3 < 5 -> true
// 6 < 4 -> false
// true & false -> false

console.log(3 < 5 || 6 < 4);

console.log(3 < 5 && 6 < 8 && 5 <= 4);
// 3 < 5 -> true
// 6 < 8 -> true
// 5 <=4 -> false
// true & true & false

console.log((3 < 5 && 6 > 3) || 5 > 3);
// 3 < 5 -> true
// 6 < 3 -> false
// 5 > 4 -> true
// true && false || true

console.log(!3 > 5);
// 3 > 5 -> false

console.log("CHALLENGE");

// Write boolean expressions for the following scenarios:
// If it is raining and cold I should bring a coat
let isRaining = true;
// let temperature = 20;

console.log("bring a coat?", isRaining && temperature < 21);
// true / true

// If I'm hungry I should eat
let hungry = true;
let wallet = 5;

console.log("I am hungry, can I afford meal?", hungry && wallet >= 8.5);

// If my petrol tank is below one quarter I should get gas
let petrolTank = 0.25;
let petrolPrice = 1.5;

console.log("Get gas?", petrolTank <= 0.25 && petrolPrice <= 2);

// If I have had 2 coffees today, I shouldn't have another
let coffeesToday = 5;

console.log("Should I have another coffee?", coffeesToday <= 2);

// If I own 5 cats, I don't need more cats
let myCats = 4;
let myName = "Alex";

console.log("Can I get another cat?", myCats <= 5 && myName === "Sandra");

// If the discount is greater than 20% or the jacket is really cool, I will buy it
let discount = 10;
let jacketCool = true;

console.log(
    "Can I get this steezy jacket?",
    discount >= 20 || jacketCool === true
);

// truthy and falsey CHALLENGE
// falsey
