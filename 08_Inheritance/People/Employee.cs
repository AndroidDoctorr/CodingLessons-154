using System;
public class Employee : Person
{
    public int EmployeeNumber { get; private set; }
    public DateTime HireDate { get; }

    public int YearsWithCompany
    {
        get
        {
            // Expression - something that results in a value
            // Examples: "blah blah"     4     9 + 3     x > 5
            double totalTime = (DateTime.Now - HireDate).TotalDays / 365.24;
            return Convert.ToInt32(Math.Floor(totalTime));
        }
    }
    // You get an empty constructor by default until you explicitly define one
    // Then you only have the ones you define
    public Employee() { }
    public Employee(
        string firstName,
        string lastName,
        string phone,
        string email,
        int employeeNumber
    ) : base(firstName, lastName, phone, email)
    {
        EmployeeNumber = employeeNumber;
        HireDate = DateTime.Now;
    }
}

public class HourlyEmployee : Employee
{
    public decimal HourlyWage { get; set; }
    public double HoursWorked { get; set; }
}

public class SalaryEmployee : Employee
{
    public decimal Salary { get; set; }
}