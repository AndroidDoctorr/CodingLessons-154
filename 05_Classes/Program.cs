Vehicle firstVehicle = new Vehicle();

firstVehicle.Make = "Honda";
firstVehicle.Model = "Civic";
firstVehicle.Mileage = 30000;
firstVehicle.Type = VehicleType.Car;

System.Console.WriteLine(firstVehicle.Make);
System.Console.WriteLine(firstVehicle.Type);

// interpolation
System.Console.WriteLine($"This is a {firstVehicle.Make} {firstVehicle.Model}");

// Create an instance of Person
// Instantiation
Person me = new Person();
me.LastName = "Torr";
me.FirstName = "Andrew";

// Same class, different instance - so different name, birthdate etc
Person you = new Person();


System.Console.WriteLine(me.FullName);

me.DateOfBirth = new DateTime(1985, 9, 22);
System.Console.WriteLine(me.Age);

Vehicle myCar = new Vehicle();
myCar.Make = "Dodge";
myCar.Model = "Journey";
myCar.Mileage = 240000;
myCar.Type = VehicleType.Spaceship;

me.Transport = myCar;
System.Console.WriteLine(
    $"My name is {me.FullName} and I have a {me.Transport.Make} {me.Transport.Model}"
);

Room someRoom = new Room();
someRoom.Length = 10;
someRoom.Width = 6;
someRoom.Height = 3;

System.Console.WriteLine(someRoom.Volume);
System.Console.WriteLine(someRoom.FloorArea);
System.Console.WriteLine(someRoom.WallArea);


Greeter greeter = new Greeter();
greeter.SayRandomGreeting();

Person person = new Person("Charlie", "Lipperd", new DateTime(1990, 1, 1));
System.Console.WriteLine(person.FullName);
System.Console.WriteLine(person.Transport);