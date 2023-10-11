using System.Diagnostics;

public class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public void Display()
    {
        string fracString = GetFractionString();
        double fracDouble = GetDecimalValue();
        Console.WriteLine();
        Console.WriteLine($"String: {fracString}");
        Console.WriteLine($"Double: {fracDouble}");
    }
    public string GetFractionString()
    {
        string frac = $"{_top}/{_bottom}";
        return frac;
    }

    public double GetDecimalValue()
    {
        double frac = (double)_top/(double)_bottom;
        return frac;
    }
}