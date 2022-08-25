public enum DietType { Herbivore, Omnivore, Carnivore }

// abstract means we aren't ever making an instance of this class
// we only use it as a basis other classes
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

    // Abstract and virtual methods require an abstract class

    // abstract method on an abstract class
    // (no implementation, must be overridden)
    // public abstract bool TryToEat(string food);



    // virtual method (base implementation, can be overridden)
    public virtual void Move()
    {
        Console.WriteLine($"This {GetType().Name} moves");



        decimal dec = 1.45436435m;
    }

    // Access modifiers
    // public - accessible anywhere
    // private - only accessible inside this class
    // protected - only accessible inside this family
    // internal - only accessible inside this folder


    public void NestedLoop()
    {
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                Console.WriteLine("hi"); // 144
            }
        }
    }

    protected void Breathe() // protected = can only be used in this family
    {

    }
}