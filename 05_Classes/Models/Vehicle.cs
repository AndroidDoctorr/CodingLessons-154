// Class = custom data object

// Classes = nouns
// Properties = adjectives
// Methods = verbs (functions)

public class Vehicle
{
    // 1 Access modifier
    // 2 Type (the type of data)
    // 3 Name of the property
    // 4 "Getters and Setters"

    // 1     2     3       4
    public string Make { get; set; }
    public string Model { get; set; }
    public double Mileage { get; set; }

    public VehicleType Type { get; set; }

    // Methods = verbs (functions, but in a Class)
    public bool IsRunning { get; private set; }


    public void TurnOn()
    {
        IsRunning = true;
        System.Console.WriteLine("You turn the vehicle on");
    }

    public void TurnOff()
    {
        IsRunning = false;
        System.Console.WriteLine("You shut off the vehicle");
    }

    public Indicator RightIndicator { get; set; }
    public Indicator LeftIndicator { get; set; }

    public void IndicateLeft()
    {
        LeftIndicator.TurnOn();
        RightIndicator.TurnOff();
    }
    public void IndicateRight()
    {
        LeftIndicator.TurnOff();
        RightIndicator.TurnOn();
    }
    public void TurnOnHazards()
    {
        RightIndicator.TurnOn();
        LeftIndicator.TurnOn();
    }
    public void ClearIndicators()
    {
        LeftIndicator.TurnOff();
        RightIndicator.TurnOff();
    }
}

public class Indicator
{
    public bool IsFlashing { get; private set; }
    public void TurnOn()
    {
        IsFlashing = true;
    }

    public void TurnOff()
    {
        IsFlashing = false;
    }
}

// Enum = custom "category" - set of options to choose from

public enum VehicleType { Car = 1, Truck, Van, Motorcycle, Spaceship, Plane, Boat };

