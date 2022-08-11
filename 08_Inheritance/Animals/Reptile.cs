public class Reptile : Animal
{
    public Reptile() { HasFur = false; NumberOfLegs = 4; }
}

public class Bird : Reptile
{
    public override void Move()
    {
        Console.WriteLine($"This {GetType().Name} flies!");
    }
}

public class Eagle : Bird
{
    public override void Move()
    {
        base.Move();
        Console.WriteLine("No, it soars!");
    }
}