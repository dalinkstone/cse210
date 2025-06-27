using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(1);
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        Console.WriteLine("This is for the one parameter 'wholenumber' fraction constructor of 1");
        f1.GetTop();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine("This is for the one parameter 'wholenumber' fraction constructor of 5");
        f2.GetTop();
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine("This is for the two parameter fraction constructor of 3/4");
        f3.GetTop();
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine("This is for the two parameter fraction constructor of 1/3");
        f4.GetTop();
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}
