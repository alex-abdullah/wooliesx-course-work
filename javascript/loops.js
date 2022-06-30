// Loops
// What is a loop?
// Why do we use them?
// What can a loop do, that we couldn't do previously?
// What are the different kinds of loops?
// How can we use loops to iterate through an array?

// What is a loop?
// A loop in programming is a piece of code that gets repeated
// Specifically, it repeats an arbitray number of times

// creating a variable
// checking if variable is smaller than a number
// increasing that variable by 1

// for (let i = 0; i < 10; i++) {
//     console.log(i);
// }

// dissecting a for loop
// 'for' keyword, used to designate it is a for loop
// before step, where we create a new variable
// condition step, which will check our variable against another value
// IF the condition is true, we'll perform the entire code block
// after step, increase our variable by 1
// Next it will go back to the condition step and will keep repeating until that condition is false

// let i = 0;
// if (i < 10) {
//     //true
//     console.log(i + 1); // 0 + 1
// }

// i++; // i = 0 --> 1

// if (i < 10) {
//     // true
//     console.log(i + 1); // 1 + 1
// }

// The most common use of a loop in JS
// I have an array

// const faveFoods = ["Pizza", "subway", "oportos"];

// // We want to log all of these to the console
// for (let i = 0; i < faveFoods.length; i++) {
//     console.log(faveFoods[2]);
// }

// The while loop
// These are simpler than 'for' loops
// Which means its easier to make mistakes

// i = 0;
// while (i < 10) {
//     console.log("i is ", i);
//     i++; // this is important
// }

// why does this happen to while loops but not for loops?

// 'For' loops have safety measures

// What are 'break' and 'continue'?
// Works very similar to return in a function.

// Break
// When a loop encounters the break keyword, the loop ends immediately

// let attempts = 0;
// let randomNumber;
// while ((randomNumber = Math.floor(Math.random() * 100))) {
//     console.log(randomNumber);
//     attempts++;
//     if (randomNumber === 7) break;
// }

// console.log("Hit 7 after ", attempts, "attempts.");

// continue
// very similar to break
// however, it will only end the current iteration

// HOMEWORK

// JS3
// loop challenge
// project work

// Challenge: Sum of n
// MVP:
// Create a function with a for loop that will add all the numbers up to n
// You should create a variable to set the upper limit of your loop
// Your loop should increment by 1 on each iteration
// Your loop should print the final result
// sum(10) => 55
// Bonus:
// Try writing the function again with the same inputs and outputs Without using a loop. (You may need to google some formulas!)

const sum = (x) => {
    let n = 0;
    for (let i = 0; i <= x; i++) {
        n += i;
    }
    return n;
};

console.log(sum(10));

const bigMaths = (a) => {
    return (a * (a + 1)) / 2;
};

console.log(bigMaths(10));

const numberArr = [1, 2, 3];
let score = 0;
for (let i = 0; i < numberArr.length; i++) {
    score += numberArr[i];
}

console.log(score);

// const generateAverage = (numberArr) => {
//     let total = 0;
//     for (let i = 0; i < numberArr.length; i++) {
//         total += numberArr[i];
//         final = total / numberArr.length;
//     }
//     return Math.round(final);
// };

// console.log(generateAverage(numberArr));
