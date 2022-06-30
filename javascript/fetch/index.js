// Fetch

// What is Fetch?

// Fetch

// What is Fetch?

// Fetch is a function that allows us to make a Get call to an API
// fetch accesses a url for us and gives us back the data

// when I type an address into my browser and hit enter
// It will make a web request to that address and return the data
// My browser will read and display the data
// html, css, js

// there are other resources on the internet other than websites
// and you can make web requests to those and receive their data

// Storing URL
const url = "https://catfact.ninja/fact";

// Using Fetch
const promiseResponse = fetch(url);

// Storing response
const response = await promiseResponse;

console.log(response);

const object = await response.json();

console.log(object);

// Creating H1 Element
const newHeader = document.createElement("h1");

// Creating text node to be filled with object
const headerContent = document.createTextNode(object.fact);

// Wanting to append header with content
newHeader.appendChild(headerContent);

// Wanting to add header to body
document.body.append(newHeader);
