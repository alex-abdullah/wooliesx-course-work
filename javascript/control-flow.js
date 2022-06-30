// Control Flow

// Objectives
// What is control flow?
// Why do we use control flow?
// What are the different control cases we can use?
// What are if statements?
// What are switch statements?
// What are loops?
// What are ternary operators?

// What is control flow?
// Control is how we alter the path of a program based on values

let iAmHungry = true;
let iAmThirsty = false;

if (iAmHungry) {
    console.log("Get food lad");
}

if (iAmThirsty) {
    console.log("drink lad");
}

// CHALLENGE

// Challenge: Odds & Evens
// MVP:
// Check if a number is odd or even
// Create variable n
// Write an if / else block
// If the number passed in is even return a string "n is even"
// If the number is odd return a string "n is odd"

// const findOddNumber = () => {
//     const n = 11;

//     if (n % 2 === 0) {
//         return "Number is EVEN";
//     } else {
//         return "Number is ODD";
//     }
// };

// console.log(findOddNumber());

const n = 11;

if (n % 2 === 0) {
    ("Number is EVEN");
} else {
    console.log("Number is ODD");
}

// Challenge: Comparing Numbers
// MVP:
// Check for the smallest value
// Create two variables x & y
// Write an if / else block
// It should compare a number x to another number y
// It should print ("x is greater than y") in the console
// Or "x is smaller than y"
// Or "x is equal to y"
// Depending on the value of x and y
// BONUS: Find the largest value out of x, y and z

let x = 51;
let y = 52;
let z = 40;

const findBigValue = () => {
    if (x > y) {
        return "x is greater than y";
    } else if (x < y) {
        return "x is smaller than y";
    } else {
        return "x is equal to y";
    }
};

console.log(findBigValue());

// let myArray = [x, y, z];
// console.log(Math.max(myArray));

// If and Else
// When to use else
// What is the difference

// Ternary Statements
// in-line if statements

let isDarkMode = true;
let backgroundColor;

if (isDarkMode) {
    backgroundColor = "#ffffff";
} else {
    backgroundColor = "#000000";
}

let backgroundColorInLine = isDarkMode ? "#ffffff" : "#000000";

// something = condition? truevalue: falsevalue

// Challenge: Eye Colour
// MVP:
// Tell the user what eye colour their child would have.
// Create two variables parent1 and parent2
// Given the eye colour of each parent, it should console log the probability of their child having different eye colours, for example: Your eye colours are brown and blue, the chances of your child having blue eyes is --%, brown is --% and green is --%
// Use the following image as a reference
// Bonus:
// Store the value of the child’s eye colour and write a switch statement - depending on the child’s eye colour consol log if it's your favourite eye colour, your least favourite eye colour or the mediocre colour

let parent1 = "brown";
let parent2 = "green";

if (parent1 === "brown" && parent2 === "brown") {
    console.log(
        "Your eye colours are brown and blue, the chances of your child having blue eyes is 6.25%, brown is 75% and green is 18.75%"
    );
} else if (parent1 === "brown" && parent2 === "blue") {
    console.log(
        "Your eye colours are brown and blue, the chances of your child having blue eyes is 50%, brown is 50% and green is 0%"
    );
} else if (parent1 === "brown" && parent2 === "green") {
    console.log(
        "Your eye colours are brown and blue, the chances of your child having blue eyes is 12.5%, brown is 50% and green is 37.5%"
    );
} else if (parent1 === "blue" && parent2 === "green") {
    console.log(
        "Your eye colours are brown and blue, the chances of your child having blue eyes is 50%, brown is 0% and green is 50%"
    );
} else if (parent1 === "blue" && parent2 === "blue") {
    console.log(
        "Your eye colours are brown and blue, the chances of your child having blue eyes is 99%, brown is 0% and green is 1%"
    );
} else if (parent1 === "green" && parent2 === "green") {
    console.log(
        "Your eye colours are brown and blue, the chances of your child having blue eyes is 25%, brown is 1% and green is 75%"
    );
} else {
    console.log("Eyes are cooked");
}

const expr = "red";

switch (expr) {
    case "green":
        console.log("Mediocre");
        break;
    case "blue":
        console.log("Least Fave");
        break;
    case "brown":
        console.log("Fave");
        break;
    default:
        console.log("Eyes are all cooked");
}
