using System;

public class Fraction // define a class named Fraction

{
    private int _top; // The class should have two attributes for the top and bottom numbers
    // Make sure the attributes are private
    // private fields to store the numerator and denominator
    private int _bottom;

    public Fraction() // Constructor that has no parameters that initializes the number to 1/1.. Abstraction is used here to hide the implementation details.
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber) // Constructor that has one parameter for the top and that initializes the denominator to 1. So that if you pass in the number 5, the fraction would be initialized to 5/1
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        if (bottom == 0) // Add validation to prevent division by zero.
        {
            throw new DivideByZeroException("Bottom cannot be zero.");
        }
        _top = top;
        _bottom = bottom;
    }

    public int Top
    {
        get => _top;
        set => _top = value;
    }

    public int Bottom
    {
        get => _bottom;
        set
        {
            if (value == 0) // Add validation to prevent division by zero.
            {
                throw new DivideByZeroException("Bottom cannot be zero.");
            }
            _bottom = value;
        }
    }

    public string GetFractionString() // method to return the fraction as a string in the format "top/bottom"
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue() // method to return the decimal value of the fraction by dividing the numerator by the denominator
    {
        return (double)_top / _bottom;
    }

}
