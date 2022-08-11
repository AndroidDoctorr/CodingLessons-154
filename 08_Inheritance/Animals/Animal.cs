public enum DietType { Herbivore, Omnivore, Carnivore }

public abstract class Animal
{
    public string Name { get; set; }
    public int NumberOfLegs { get; set; }
    public bool HasFur { get; set; }
    public DietType Diet { get; set; }

    public Animal()
    {
        Console.WriteLine("This is the Animal Constructor");
    }

    public virtual void Move()
    {
        Console.WriteLine($"This {GetType().Name} moves");
    }
}