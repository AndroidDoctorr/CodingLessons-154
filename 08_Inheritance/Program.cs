Person person = new Person("Andrew", "Torr", "123-456-7890", "email@email.com");

// Inheritance adds properties and methods - it extends another class
Employee employee = new Employee("Andrew", "Torr", "123-456-7890", "email@email.com", 12345);
System.Console.WriteLine(employee.YearsWithCompany);

System.Console.WriteLine(person is Person);
System.Console.WriteLine(person is Employee);
System.Console.WriteLine(employee is Person);
System.Console.WriteLine(employee is Employee);

List<int> someList = new List<int>();
System.Console.WriteLine(someList is ICollection<int>);
System.Console.WriteLine(someList is ICollection<string>);
System.Console.WriteLine(someList is IList<int>);
System.Console.WriteLine(someList is object);

System.Console.WriteLine("adding some space\n\n\n");
HourlyEmployee hourlyEmployee = new HourlyEmployee();
System.Console.WriteLine(hourlyEmployee is HourlyEmployee);
System.Console.WriteLine(hourlyEmployee is Employee);
System.Console.WriteLine(hourlyEmployee is Person);

Console.WriteLine("\n\n\n");
Dog myDog = new Dog();
myDog.Move();
Console.WriteLine(myDog.Diet);

// Animal is abstract so we can't make an instance of it
// We can make instances of mammals, reptiles, and whatever else inherits from it

// Animal someAnimal = new Animal();
// someAnimal.Move();

// Polymorphism - having different versions of things
Eagle eagle = new Eagle();
eagle.Move();


Animal animal = new Mammal();
animal.NestedLoop();


int[] nums = { 1, 2, 3, 4, 5 };

Console.WriteLine(nums[5]);