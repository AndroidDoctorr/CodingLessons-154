
public class Greeter
{
    // overloaded method = two (or more) of the same name

    // Method
    // 1 - Access modifier - which classes can use this?
    // 2 - Return type - what does this method return/give back/output
    // 3 - Signature
    // 3a - Name
    // 3b - Parameters (input)
    // 4 - Body (the lines of code executed)

    // 1    2     3a        3b
    public void SayHello(string name)
    {
        // 4
        Console.WriteLine($"Hello, {name}!");
    }
    // method overload
    public void SayHello()
    {
        Console.WriteLine("Howdy, stranger!");
    }

    // field = private property
    private Random _random = new Random();
    public void SayRandomGreeting()
    {
        string greeting = GenerateRandomGreeting();
        System.Console.WriteLine($"{greeting}!");
    }

    private string GenerateRandomGreeting()
    {
        string[] availableGreetings = { "Hello", "Howdy", "Hola", "Hallo", "NuqneH", "Bonjour", "नमस्ते", "你好" };
        int randomNumber = _random.Next(0, availableGreetings.Length);
        string randomGreeting = availableGreetings.ElementAt(randomNumber);
        randomGreeting = availableGreetings[randomNumber];

        return randomGreeting;
    }
}