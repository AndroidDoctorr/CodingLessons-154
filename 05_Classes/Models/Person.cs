public class Person
{
    public string FirstName { get; set; }

    // backing field
    private string _lastName;
    public string LastName
    {
        set { _lastName = value.ToUpper(); }
        get { return _lastName; }
    }

    public string FullName
    {
        get { return $"{LastName}, {FirstName}"; }
    }

    public DateTime DateOfBirth { get; set; }

    public int Age
    {
        get
        {
            TimeSpan ageTotal = DateTime.Now - DateOfBirth;
            double days = ageTotal.TotalDays;
            double years = days / 365.24;

            return (int)Math.Floor(years);
        }
    }

    public Vehicle Transport { get; set; }

    // Constructor
    // kind of a special type of method - creates an instance of a class
    // Empty constructor
    public Person()
    {

    }
    // constructor overload (full constructor)
    public Person(string firstName, string lastName, DateTime birthDate)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = birthDate;
    }
}