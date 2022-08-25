public class Mammal : Animal
{
    public string FurColor { get; set; }
    public Mammal() : base()
    {
        Console.WriteLine("This is the Mammal constructor");
        HasFur = true;
        NumberOfLegs = 4;
    }

    public override void Move()
    {
        Breathe();
        Console.WriteLine($"This {GetType().Name} runs");
    }
}

public class Dog : Mammal
{
    public Dog() : base()
    {
        Console.WriteLine("This is the Dog constructor");
        Diet = DietType.Carnivore;
    }


}