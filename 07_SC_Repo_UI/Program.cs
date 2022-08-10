ProgramUI ui = new ProgramUI();
ui.Run();

/*
Enumerable.Range(1, 100).ToList();
int limit = 100;
// Select is a LINQ method that converts each item
Enumerable.Range(1, limit).Select(n =>
    // These are nested ternaries
    (n % 15 == 0) ? "FizzBuzz" :
    (n % 5 == 0) ? "Buzz" :
    (n % 3 == 0) ? "Fizz" : n.ToString()
).ToList().ForEach(s => Console.WriteLine(s));
*/