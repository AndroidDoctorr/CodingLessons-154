// top-level code (executed when the page loads)
// each line is executed in order
console.log("hello world");

add(3, 8);

// function (can be called whenever)
// a function is a set of re-usable instructions
function doSomething() {
  // quotes means string (text)
  console.log("Do Something!!");

  // save the return value as a variable
  var three = 3;
  var squ = square(three);

  squ = square(5);
  console.log(squ);
}

// function with a parameter (number) = input
function square(number) {
  // variable declaration + assign a value
  var sq = number * number;
  // return statement = output
  return sq;
}

function shout() {
  console.log("HEY!!");
}

function add(a, b) {
  var sum = a + b;
  console.log(sum);
}
