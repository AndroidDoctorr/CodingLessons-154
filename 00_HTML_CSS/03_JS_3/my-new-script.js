// window.onload = getRandomGreeting();

function getRandomGreeting() {
  var randomNumber = Math.random() * 5;
  console.log(randomNumber);

  var header = document.getElementById("randomGreeting");
  console.log(header);

  if (randomNumber > 4) {
    header.innerHTML = "Hello!";
  } else if (randomNumber > 3) {
    header.innerHTML = "What's up??";
  } else if (randomNumber > 2) {
    header.innerHTML = "Was geht?";
  } else if (randomNumber > 1) {
    header.innerHTML = "¿Cómo estás?";
  } else {
    header.innerHTML = "NuqneH!";
  }

  var r = Math.random() * 127 + 128;
  var g = Math.random() * 127 + 128;
  var b = Math.random() * 127 + 128;
  header.style.backgroundColor = "rgb(" + r + "," + g + "," + b + ")";

  // css: background-color
  // js:  backgroundColor

  // thisIsCamelCase    (JS)
  // ThisIsPascalCase   (C#)
  // this-is-kebab-case (css)
  // this_is_snake_case (Python?)
}
