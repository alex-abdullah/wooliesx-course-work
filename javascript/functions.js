// Functions

// The verb of javascript
// An action

const run = () => {
    console.log("I am running lad");
};

// Using functions
run();

// Is creating a function the same as declaring a function?

let myVariable; // declaration

myVariable = "Hello"; // assigning the value "hello" to myVariable

// calling a function and referencing the name of a variable
// that stores the function are two different things
// DECLARE & DEFINE at the same time

const newFunction = (parameter) => {
    console.log(parameter + "!!!");
    return 100;
};

// const meaningOfLife = newFunction("Hey");
// console.log(meaningOfLife);

// Difference between old school and new school functions

function meaningOfLife() {
    return 10000;
}

// Function challenge
// Challenge: Calculating Moon Orbits

// MVP
// Write a function that takes in a number of earth days, and returns the number of orbits the moon can perform given days.
// moonOrbits(54) => 2
// moonOrbits(365) => 13.359

// Challenge: Working with Circles

// MVP
// Write a function that takes the radius of a circle and return its area.
// Write a function that takes the radius of a circle and return its perimeter.
// circleArea(10) => 314.16
// circlePerimeter(10) => 62.83

// Challenge: Years to Days & Seconds

// MVP
// Create a function that takes your age in years and returns your age in days.
// Create a function that takes your age in years and returns your age in seconds.
// ageInDays(32) => 11680
// ageInSeconds(32) => 1009152000
// Caveat: Your functions are not allowed to use console.log()!

const moonOrbitFunction = (earthDays) => {
    return earthDays / 27;
};

console.log(moonOrbitFunction(400));

//

const areaCircle = (radius) => {
    const area = Math.PI * radius ** 2;
    return area;
};

console.log(areaCircle(10));

const perimeterCircle = (radius) => {
    const perimeter = 2 * Math.PI * radius;
    return perimeter;
};

console.log(perimeterCircle(10));

const dayAge = (years) => {
    const days = years * 365;
    return days;
};
console.log(dayAge(25));

const secondAge = (years) => {
    const seconds = years * 3.154e7;
    return seconds;
};

console.log(secondAge(25));

// default paramaters

const createGreeting = (lastName, rank = "Pvt") => {
    return `Hello ${rank} ${lastName}`;
};

console.log(createGreeting("Radja", "Captain"));
console.log(createGreeting("Radja"));

// Challenge: Basketball Points
// MVP
// You are counting points for a basketball game, given the amount of 2-pointers scored and 3-pointers scored, find the final points for the team and return that value.

// Challenge: Less Than 100?
// MVP
// Given two numbers, return true if the sum of both numbers is less than 100. Otherwise return false.
// lessThan100(22, 15) ➞ true
// // 22 + 15 = 37

// lessThan100(83, 34) ➞ false
// // 83 + 34 = 117

// lessThan100(3, 77) ➞ true

// BBALL SCORE
const ballScore = (twoPointers, threePointers) => {
    totalBallScore = twoPointers * 2 + threePointers * 3;
    return totalBallScore;
};

console.log(ballScore(10, 10));

// <100
const isItOneHundred = (number1, number2) => {
    const bigNumber = number1 + number2;
    if (bigNumber < 100) {
        return true;
    } else {
        return false;
    }
};

console.log(isItOneHundred(80, 20));
