// For loops

// 1 - starting action
// 2 - loop condition (keep looping while this is true)
// 3 - between loop action
// 4 - the code executed each loop

//        1        2      3
for (int i = 0; i <= 20; i++)
{
    // 4
    // Console.WriteLine($"i: {i}");
    Console.WriteLine(i % 2 == 0 ? "Even" : "Odd");
}

// Foreach loop

string[] days = { "Monday", "Tuesday", "Wednesday" };

foreach (string day in days)
{
    System.Console.WriteLine(day);
}

bool capitalize = true;
foreach (char letter in "supercalifrawhatever")
{
    if (capitalize)
    {
        System.Console.WriteLine(letter.ToString().ToUpper());
    }
    else
    {
        System.Console.WriteLine(letter);
    }

    capitalize = !capitalize;
}

// While loops

int x = 0;
// check THEN loop
while (x < 5)
{
    System.Console.WriteLine($"X is still less than 5: {x}");
    x++;
}

System.Console.WriteLine("Now it's 5");

while (false)
{
    System.Console.WriteLine("This will never happen");
}

// loop THEN check
do
{
    System.Console.WriteLine("Will this happen?");
} while (x > 10);