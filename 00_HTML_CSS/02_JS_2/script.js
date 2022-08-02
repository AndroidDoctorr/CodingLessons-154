var clicks = 0;

function count() {
  clicks = clicks + 1;
  console.log(clicks);
  // alert(clicks);
  square(clicks);
}

// num is a parameter - a special kind of variable that
//   only exists in this function, as input
function square(num) {
  var sq = num * num;
  console.log(sq);
}

function sayHello() {
  // getElementById returns an HTML element with a particular id, if it exists
  var nameInput = document.getElementById("nameInput");
  var name = nameInput.value;

  // string = text
  // you can use + to put strings together
  alert("Hello " + name);
}

function loopLetters() {
  var nameInput = document.getElementById("nameInput");
  var name = nameInput.value;

  // loop control variable counts the loops
  //   start      rule    each loop
  for (var i = 0; i < 20; i++) {
    console.log(i);
  }

  console.log("end of loop");

  for (var x = 0; x < name.length; x += 1) {
    var letter = name[x];

    if (letter == "e") {
      console.log("EEEEEEEEEEEEE");
    } else {
      console.log(letter);
    }
  }
}

function fizzBuzz() {
  for (var i = 1; i <= 100; i++) {
    // console.log(i);
    if (i % 15 == 0) {
      console.log("FizzBuzz");
    } else if (i % 3 == 0) {
      console.log("Fizz");
    } else if (i % 5 == 0) {
      console.log("Buzz");
    } else {
      console.log(i);
    }
  }
}
