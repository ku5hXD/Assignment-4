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


class PermanentEmployee : Employee
{

    private double _hra;
    private double _da;
    private double _pf;

    private string _joiningDate;
    private string _retirementDate;

    public PermanentEmployee(string first, string last, double salary, string joining, string retirement) : base(first, last, salary)
    {
        _da = base.MonthlySalary * 0.12;
        _hra = (_da + base.MonthlySalary) * 0.5;
        _pf = base.MonthlySalary * 0.12;
        _joiningDate = joining;
        _retirementDate = retirement;
    }

    public double HRA
    {
        get => _hra;
    }

    public double DA
    {
        get => _da;
    }

    public double PF
    {
        get => _pf;
    }


    public string JoiningDate
    {
        get => _joiningDate;
        set
        {
            _joiningDate = value;
        }
    }

    public string RetirementDate
    {
        get => _retirementDate;

        set
        {
            _retirementDate = value;
        }
    }

    public override void giveRaise(double raise)
    {
        base.giveRaise(raise);
        MonthlySalary = MonthlySalary + HRA + DA;
    }


    public override string ToString()
    {
        return base.ToString() + "\n" + "Joining Date: " + _joiningDate + ", Retirement Date: " + _retirementDate;
    }


}
class Program
{
    static void Main()
    {
        PermanentEmployee pe1 = new PermanentEmployee("kush", "parmar", 1200, "20-02-2022", "20-02-2032");
        Console.WriteLine("\n" + pe1);
        Console.WriteLine("\nAfter Raise :");
        pe1.giveRaise(10);
        Console.WriteLine("\n" + pe1 + "\n");
    }
}