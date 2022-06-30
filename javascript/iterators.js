// Iterators

console.log("test");

// What is an iterator?

// An iterator is an array method
// Meaning it is a function that relates to a specific array
// There are a number of iterator methods and each one of them does something slightly different
// Iterators are loops
// Effectively, an iterator is a fancy way of writing common loop functionality

// Some smart people realised that when we use loops and arrays
// They typically fall into a number of different categories:

const students = ["liz", "harley", "esther", "clint"];

// A map
// Modify every item in an array with the same operation

// Return a copy of the array where all the strings have been capitalised
const makeArrayAllCaps = (array) => {
    const newArray = [];
    for (let i = 0; i < array.length; i++) {
        newArray.push(array[i].toUpperCase());
    }
    return newArray;
};

console.log(students);
console.log(makeArrayAllCaps(students));

// A filter
// When we want a smaller array based on the items in our array

// Returns an array that removes every name less than 4 characters long
const removeShortNames = (array) => {
    const newArray = [];
    for (let i = 0; i < array.length; i++) {
        if (array[i].length >= 4) {
            newArray.push(array[i]);
        }
    }
    return newArray;
};

console.log(removeShortNames(students));

// Every
// We want to test if every item in an array passes a condition

// Returns true if every name starts with a capital letter
// Or false if any name does not
const everyNameStartsInCaps = (array) => {
    for (i = 0; i < array.length; i++) {
        if (array[i][0] !== array[i][0].toUpperCase()) {
            return false;
        }
    }
    return true;
};

console.log(everyNameStartsInCaps(students));

// Some
// We want to test if some items in an array pass a condition

// + more

// What are our iterators?
// Iterators are pre-written methods (functions) that give us the ability to easily write common code without having to write a whole for loop every single time.

// map
const makeCapital = (word) => {
    return word.toUpperCase();
};

// map takes in a function as a parameter and will return a new array that has had that function called on every item
console.log(students.map(makeCapital));

console.log(students.map((word) => word.toUpperCase()));

console.log(
    students.map((name) => {
        return name.length;
    })
);
// students is our array
// map function <-- returns NEW array that has had the callback function run on every item
// makeCapital <-- callback function
// if your callback function does not return a value, your map will be empty

// Map is our most common iterator

// Filter

// I want to get a new array that has a subst of items of the previous array based on a rule (has to be true/false)

const longNameStudent = students.filter((student) => student.length > 3);
const filterFunction = (student) => student.length > 3;

console.log(filterFunction("alex"));
console.log(filterFunction("liz"));
console.log(filterFunction("jeffro"));
console.log(filterFunction("alberto"));

console.log(longNameStudent);
console.log(students);

// Every
const wordStartsWithCaps = (student) => student[0] !== student[0].toUpperCase();

console.log(students.every(wordStartsWithCaps));

// OR

students.every((student) => student[0] !== student[0].toUpperCase());

// Why iterators are great
// They simply our code
// Faster to write
// Easier to read
// Less chance of human error

// What would we want to find?

// Find the first name that has the letter "e"

// Pass a condition = return true
console.log(students.find((name) => name.includes("e")));

booleanArr = [(true, true, false, false, true)];

const removeFalseValues = (booleanArr) => {
    const trueOnly = booleanArr.filter((x) => x === true);
    return trueOnly;
};

console.log(removeFalseValues(booleanArr));

numberString = "1+2+3+4+5";

const convertStringToNumbersArray = (numberString) => {
    const newString = numberString.split("+");
    const numbers = newString.map((number) => +number);
    return numbers;
};

console.log(convertStringToNumbersArray(numberString));

const createOddEvenArray = (numberString) => {
    // % to test if number is odd/even
    // if statement to determine if number will return odd or even
    const newString = numberString.split("+");
    const numbers = newString.map((number) => +number);
    const oddEvenString = numbers.map((x) => {
        if (x % 2 !== 0) {
            return "odd";
        } else {
            return "even";
        }
    });

    return oddEvenString;
};

console.log(createOddEvenArray(numberString));

// const source = [1, 2, 3, 4, 5];
// const destination = [];

// // for (i = 0; i < source.length; i++) {
// //     destination.push(source[i] + 1);
// // }

// const spicy = source.map((array) => {
//     const newNumber = number + 1;
//     destination.push(newNumber);
//     return destination;
// });

// console.log(spicy);

let string = " 22 $$He LL--O!%^& ";

const formatString = (string) => {
    const noSpecialCharacters = string.replace(/[^a-zA-Z ]/g, "");
    // console.log(noSpecialCharacters); // He LLO
    const amendedString = noSpecialCharacters.replace(/\s+/g, "");
    const newArray = amendedString.split("");

    console.log(newArray);
};

formatString(string);
