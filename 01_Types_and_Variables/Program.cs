// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Value Types
int a = 5;   // 4 bytes, -2,147,483,648 to 2,147,483,647

long l = 3000000000;  // 8 bytes

float f = 3.5f;   // 4 bytes, but includes a decimal

double d = 3.5;   // 8 bytes, including a decimal

decimal dec = 3.56857456345231432654m;  // 16 bytes

bool b = true;  // 1 bit

bool isEven = (a % 2 == 0);

byte aByte = 255;

char c = 'A';  // (symbol) 2 bytes

string s = "this is a string!!124  \nnew line!!";
Console.WriteLine(s);

Console.WriteLine(1.2578907289045789789789789787897f);
Console.WriteLine(1.2578907289045789789789789787897d);
Console.WriteLine(1.2578907289045789789789789787897m);

// Structs
DateTime now = DateTime.Now;
Console.WriteLine(now.DayOfWeek);

DateTime birthday = new DateTime(1985, 9, 22);
System.Console.WriteLine(birthday.DayOfWeek);

// Declared, NOT initialized
string someString;
// Declared AND initialized
string anotherString = "dsgfdh";
// System.Console.WriteLine(someString); <- can't use an uninitialized variable


// Reference Types

// Strings are reference types
string firstName = "Andrew";
string lastName = "Torr";

string concatenated = firstName + " " + lastName;

string interpolated = $"My name is {firstName} {lastName}";
System.Console.WriteLine(interpolated);

string composited = string.Format("{0} {1}", firstName, lastName);

// Arrays
int[] intArray = { 1, 2, 3 };

float[] floatArray = { 1.5f, 3.14f, 6.8f }; // need "f" because by default it makes them doubles

string[] stringArray = { "Hello", "World",
"why", "is", "it", "always", "'hello world'??", interpolated};

System.Console.WriteLine(stringArray[5]);
stringArray[5] = "usually";
System.Console.WriteLine(stringArray[5]);

List<string> listOfStrings = new List<string>();

listOfStrings.Add("sfdsgfdh");
listOfStrings.Add("     ");
listOfStrings.Add(interpolated);

listOfStrings.RemoveAt(0);

// Dictionaries

Dictionary<string, string> emailReference = new Dictionary<string, string>();
emailReference.Add("Andrew", "andrewemail@email.com");

string email = emailReference["Andrew"];
System.Console.WriteLine(email);

Dictionary<string, string> abbreviations = new Dictionary<string, string>();
abbreviations.Add("abbr", "abbreviation");
abbreviations.Add("pp", "pages");
abbreviations.Add("etc", "et cetera");

string abbr = abbreviations["abbr"];

// importantNumbers is an instance of the Dictionary class
// "Dictionary" is the class itself
Dictionary<string, double> importantNumbers = new Dictionary<string, double>();
importantNumbers.Add("pi", 3.1415926);
importantNumbers.Add("e", 2.7182818284);
importantNumbers.Add("phi", 1.618034);

// Queues
Queue<string> firstInFirstOut = new Queue<string>();
firstInFirstOut.Enqueue("me first");
firstInFirstOut.Enqueue("me two");

System.Console.WriteLine(firstInFirstOut.Peek());
System.Console.WriteLine(firstInFirstOut.Dequeue());
System.Console.WriteLine(firstInFirstOut.Dequeue());
// System.Console.WriteLine(firstInFirstOut.Dequeue());

// Classes (sort of)
// use "new" to create a class or struct instance
Random rng = new Random();

System.Console.WriteLine(rng.NextDouble() * 100);
System.Console.WriteLine(rng.NextDouble() * 100);
