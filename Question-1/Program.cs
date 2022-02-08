using System;

class Employee
{
    private string _firstName;
    private string _lastName;
    private double _monthlySalary;

    public Employee(string first, string last, double salary)
    {
        _firstName = first;
        _lastName = last;
        if (salary < 0)
            _monthlySalary = 0.0;
        else
            _monthlySalary = salary;
    }
    public string FirstName
    {
        get => _firstName;
        set => _firstName = value;
    }

    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }

    public double MonthlySalary
    {
        get => _monthlySalary;
        set
        {
            if (value < 0)
                _monthlySalary = 0.0;
            else
                _monthlySalary = value;
        }
    }

    public virtual void giveRaise(double percentage)
    {
        _monthlySalary += _monthlySalary * (percentage / 100);
    }

    public override string ToString()
    {
        return "NAME: " + FirstName + " " + LastName + " , YEARLY SALARY: $" + MonthlySalary * 12;
    }


}
class Program
{
    static void Main()
    {
        Employee e1 = new Employee("kush", "parmar", 20.0);
        Employee e2 = new Employee("parmar", "kush", 150.0);

        Console.WriteLine("\n" + e1);
        Console.WriteLine(e2);

        e1.giveRaise(10);
        e2.giveRaise(30);

        Console.WriteLine("\nAfter Raise: \n");

        Console.WriteLine(e1);
        Console.WriteLine(e2 + "\n");

    }
}