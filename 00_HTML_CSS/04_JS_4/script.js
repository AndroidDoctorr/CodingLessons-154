// can change the value
let x = 5;

// can't change the value
const y = 7;

x = 8;
// x = document.getElementById("someInput").value;

// y = 9;

console.log(x);
console.log(y);

// Arrays

let someArray = [1, 2, 3];

someArray.push(5);

console.log(someArray);

let anotherArray = [
  // TYPES:
  1, // number
  "e", // string
  ["h", "e", "l", "l", "o"], // array
  "word", // string
  true, // boolean
  false,
  "sdgffghhgf",
  {}, // object
  () => {}, // function (shorthand)
  null, // object
  undefined, // undefined
];

console.log(anotherArray);
console.log(anotherArray[3]);

for (let i = 0; i < someArray.length; i++) {
  console.log(someArray[i]);
}

// Objects

let someObject = {
  // objects have properties (sometimes called "keys")
  name: "Andrew",
  // "name" is a property, "Andrew" is its value
  email: "whatever@email.com",
  occupation: "Coding Instructor",
  snake_case_prop: true,
  letters: ["A", "N", "D"],
};

console.log(someObject.email);

// undefined and null
let c;
console.log(c);

if (c == undefined) {
  console.log("c is undefined");
}

let n = null;
// == same value
console.log(1 == "1");
// === same value AND the same type
console.log(1 === "1");

if (x == 2) {
  console.log("x is 2");
}

// switch case - for specific values

switch (x) {
  case 1:
    console.log("option 1");
    break;
  case 2:
    console.log("option 2");
    break;
  default:
    console.log("something else");
}
