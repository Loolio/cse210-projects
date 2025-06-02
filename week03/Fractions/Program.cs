using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);

        Console.WriteLine("Initial Fractions:");
        DisplayFraction(f1);
        DisplayFraction(f2);
        DisplayFraction(f3);

        f1.Top = 3;
        f1.Bottom = 4;

        f2.Top = 1;
        f2.Bottom = 3;

        Console.WriteLine("\nUpdated Fractions:");
        DisplayFraction(f1);
        DisplayFraction(f2);

        Console.WriteLine("\nOther additional Fractions: ");
        Fraction f4 = new Fraction(1);
        Fraction f5 = new Fraction(5);
        Fraction f6 = new Fraction(3, 4);
        Fraction f7 = new Fraction(1, 3);

        DisplayFraction(f4);
        DisplayFraction(f5);
        DisplayFraction(f6);
        DisplayFraction(f7);
    }

    static void DisplayFraction(Fraction f)
    {
        Console.WriteLine($"Fraction: {f.GetFractionString()} = {f.GetDecimalValue()}");
    }
}