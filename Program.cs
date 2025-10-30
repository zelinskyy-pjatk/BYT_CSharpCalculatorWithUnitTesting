using System;
using BYT_CalculatorWithUnitTesting;

public class Program
{
    public static void Main(string[] args)
    {
        var calculator = new Calculator(10, 2, '/');
        double res = calculator.Calculate();
        Console.WriteLine($"Result: {res}");
    }
}