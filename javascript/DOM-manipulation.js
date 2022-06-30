// Document Object Model Manipulation

// What is the DOM
// The DOM is the JS/data understanding of the structure of an HTML page
// The browser will read a HTML file and construct the DOM when the page is loaded

console.log(document.body);

// Has a children attribute which contains our children elements as HTML
console.log(document.body.children);

console.log(document.body.children[0].innerHTML);

const pageHeading = document.querySelector("#mainHeading");

pageHeading.innerHTML = "The Time is now:";
document.querySelector("#timeParagraph").innerHTML =
    new Date().toLocaleString();

// Modify classes
pageHeading.classList.add("heading");
pageHeading.classList.add("heading__main");

document.querySelectorAll(".para");
console.log(document.querySelectorAll("p"));

document.getElementById("#mainHeading"); // not plural, just 1 item
document.getElementsByClassName(".heading"); // plural, array
document.getElementsByTagName("h1"); // plural, array

// Find the button
const darkModeButton = document.getElementById("darkModeButton");
console.log(darkModeButton.innerHTML);

// Write button function
const toggleDarkMode = () => {
    // find all text elements
    const textElements = document.getElementsByClassName("text");
    // add the dark class to all elements
    for (let i = 0; i < textElements.length; i++) {
        textElements[i].classList.toggle("text--dark");
    }
    // Make the background change
    document.body.classList.toggle("page--dark");
};

// THEN, apply function to button
// We want to call the addEventListener method
// It takes in 2 parameters
// An event and a callback function
darkModeButton.addEventListener("click", toggleDarkMode);
