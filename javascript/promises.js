// What is a promise?
// Agreement to do something or not

// synchronous programming - blocking

// asynchronous / non-blocking

// What is an API? Application Programming Interface
// -> allow programs to communicate with one another

// CRUD -> CREATE, READ, UPDATE, DELETE
// P0ST, GET, PATCH, DELETE => HTTP METHODS

// HTTP => HyperText Transfer Protocol => used to structure requests and responses over the internet

// RESTful APIs => working with JSON (JS object notation)

// REST => Representational State Transfer => style for providing standards between computers

// Why do we need promises? We want to be able to perform non-blocking actions -> Like talking to APIs

// NON-blocking

// TIMERS

// setTimeout(() => {
//     console.log("I am a timed response");
// }, 2000);

// console.log("I will run first");

// INTERVALS
// setInterval(() => {
//     console.log("I am in the interval");
// }, 1000);

// OUTCOME STATES
// pending / in progress
// resolved / success
// rejected / fail

// const timeoutPromise = new Promise((resolve, reject) => {
//     setTimeout(() => {
//         const randomNumber = Math.floor(Math.random() * 10);
//         if (randomNumber % 2 === 0) {
//             resolve(`The resolved value is ${randomNumber}`);
//         } else {
//             reject(`The number generated was invalid`);
//         }
//     }, 3000);
// });

// console.log(timeoutPromise);

//.then AND .catch

// timeoutPromise
//     .then((res) => console.log(res))
//     .catch((rej) => {
//         console.log(rej);
//         timeoutPromise;
//     });

// Function that returns a promise

// const timedIncrement = (initial, timeout) => {
//     return new Promise((resolve, reject) => {
//         setTimeout(() => {
//             console.log("Timeout is running");
//             resolve(initial + 1);
//         }, timeout);
//     });
// };

// timedIncrement(5, 2000)
//     .then((res) => {
//         console.log(res);
//         return timedIncrement(res, 1000);
//     })
//     .then((n) => {
//         console.log(n);
//         return timedIncrement(n, 1000);
//     })
//     .then((x) => {
//         console.log(x);
//     })
//     .catch((rej) => console.log(rej));

// CHALLENGE

// n: Initial number
// mode: mode should take in either inc or dec, and should change whether the function increments or decrements
// timeout: the delay time, should default to 2.5 seconds

const delayedIncDec = (n, mode, timeout) => {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            console.log("Hopefully this is working");
            if (mode === "inc") {
                resolve(n + 1);
            } else if (mode === "dec") {
                resolve(n - 1);
            } else reject("BIG ERROR BOY");
        }, timeout);
    });
};

delayedIncDec(Math.floor(Math.random() * 15), "inc", 2500).then((res) => {
    console.log(res);
});
