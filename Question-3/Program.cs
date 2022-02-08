// METHOD HIDING
using System;

public class BaseClass
{

    public void baseClassMethod()
    {
        Console.WriteLine("Hello, I am Base Class Method");
    }
}

public class DerivedClass : BaseClass
{

    public new void baseClassMethod()
    {
        Console.WriteLine("Hello, I am Derived Class's Method ");
    }
}


class Program
{

    static public void Main()
    {

        DerivedClass obj = new DerivedClass();
        Console.WriteLine("\n-------------CONCEPT OF METHOD HIDING--------------------\n");
        obj.baseClassMethod();
        Console.WriteLine("\n");
    }
}
