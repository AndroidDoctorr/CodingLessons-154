// Arithmetic Operators

int a = 22;
int b = 15;

System.Console.WriteLine(a + b);
System.Console.WriteLine(a - b);
System.Console.WriteLine(a * b);
System.Console.WriteLine((double)a / (double)b);  // casting - turn one type into another compatible type
System.Console.WriteLine(a % b);

// 1 byte = 8 bits (ones and zeros)
char c = 'a';
byte byteC = (byte)c;
int intC = (int)c;
System.Console.WriteLine(intC);

DateTime today = DateTime.Now;
DateTime someDay = new DateTime(1978, 1, 1);

TimeSpan timeSpan = today - someDay;
System.Console.WriteLine(timeSpan.TotalDays / 365.24);

// Comparison Operators
System.Console.WriteLine(a > b);
System.Console.WriteLine(a >= b);
System.Console.WriteLine(a < b);
System.Console.WriteLine(a == b);
System.Console.WriteLine(a != b);

string name = "Andrew";
List<string> nameList = new List<string>();
nameList.Add(name);

List<string> otherList = new List<string>();
otherList.Add(name);

System.Console.WriteLine("Lists equal??");
// Lists are reference types, so these are references (addresses in memory)
System.Console.WriteLine(nameList == otherList);

System.Console.WriteLine(a < b || a > 20);
System.Console.WriteLine(a < b && a > 20);
bool someBool = ((a < b) || (a > b && a < 20)) || (a < b);
System.Console.WriteLine(someBool);
