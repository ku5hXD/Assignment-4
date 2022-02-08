// METHOD OVERLOADING
using System;

public class MATHEMATICS
{

    public int Add(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    // same method name but different parameters
    public int Add(int a, int b, int c)
    {
        int sum = a + b + c;
        return sum;
    }
}


class Program
{

    static public void Main()
    {

        MATHEMATICS m1 = new MATHEMATICS();
        Console.WriteLine("\n-------------CONCEPT OF METHOD OVERLOADING--------------------\n");

        Console.WriteLine($"Calling First Method : \n SUM = {m1.Add(1, 2)}\n\n");

        Console.WriteLine($"Calling Second Method : \n SUM = {m1.Add(1, 2, 3)}\n\n");
    }
}
