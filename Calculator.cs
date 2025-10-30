namespace BYT_CalculatorWithUnitTesting;

public class Calculator
{
    private readonly double A;
    private readonly double B;
    private readonly char Operation;

    public Calculator(double a, double b, char operation)
    {
        A = a;
        B = b;
        Operation = operation;
    }

    public double Calculate()
    {
        return Operation switch
        {
            '+' => A + B,
            '-' => A - B,
            '*' => A * B,
            '/' => B != 0 ? A / B : throw new DivideByZeroException("It is not possible to divide by zero."),
            _ => throw new InvalidOperationException($"Unknown operation: {Operation}")
        };
    }
}