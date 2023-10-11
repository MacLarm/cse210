using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new Fraction();
        one.Display();
        one.SetTop(5);
        one.Display();
        one.SetTop(3);
        one.SetBottom(4);
        one.Display();
        one.SetTop(1);
        one.SetBottom(3);
        one.Display();
    }
}