bool userIsHungry = true;
bool lectureIsHappening = true;

// ! = not
if (userIsHungry && !lectureIsHappening)
{
    System.Console.WriteLine("Go eat something!");
}
else
{
    System.Console.WriteLine("hang on a bit");
}

int hoursOfSleep = 3;
if (hoursOfSleep >= 8)
{
    System.Console.WriteLine("You should be well rested");
}
else
{
    if (hoursOfSleep < 4)
    {
        System.Console.WriteLine("You should get more sleep");
    }
}

int age = 36;
if (age >= 65)
{
    System.Console.WriteLine("You're a senior");
}
else if (age >= 21)
{
    System.Console.WriteLine("You're an adult who can drink");
}
else if (age >= 18)
{
    System.Console.WriteLine("You're an adult but you can't drink");
}
else if (age >= 0)
{
    System.Console.WriteLine("You're a child");
}
else
{
    System.Console.WriteLine("You don't exist yet");
}

// switch cases
string today = DateTime.Now.DayOfWeek.ToString();

switch (today)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        Console.WriteLine("Time to work!");
        break;
    case "Saturday":
    case "Sunday":
        Console.WriteLine("Sorry we're closed");
        break;
    default:
        Console.WriteLine("What planet are you from?");
        break;
}


int option = 2;
// Switch expression
string outputString = option switch
{
    1 => "Option 1",
    2 => "Option 2",
    3 => "Option 3",
    _ => "Default"
};

System.Console.WriteLine(outputString);

// Ternary expression
string ticketType = (age >= 18) ? "Adult" : "Child";