using NUnit.Framework;
namespace BYT_CalculatorWithUnitTesting;

public class CalculatorTests
{
    // -- Standard Arithmetic Operations Tests -- //

    [Test]
    public void AdditionTest()
    {
        var calculator = new Calculator(16, 2, '+');
        Assert.That(calculator.Calculate(), Is.EqualTo(18));
    }

    [Test]
    public void SubtractionTest()
    {
        var calculator = new Calculator(11, 4, '-');
        Assert.That(calculator.Calculate(), Is.EqualTo(7));
    }

    [Test]
    public void MultiplicationTest()
    {
        var calculator = new Calculator(12, 12, '*');
        Assert.That(calculator.Calculate(), Is.EqualTo(144));
    }

    [Test]
    public void DivisionTest()
    {
        var calculator = new Calculator(16, 2, '/');
        Assert.That(calculator.Calculate(), Is.EqualTo(8));
    }
    
    // -- Extra Available Scenarios -- //

    [Test]
    public void TestDivisionByZero_ExceptionThrown()
    {
        var calculator = new Calculator(5, 0, '/');
        Assert.Throws<DivideByZeroException>(() => calculator.Calculate());
    }

    [Test]
    public void InvalidOperation_ExceptionThrown()
    {
        var calculator = new Calculator(5, 2, '&');
        Assert.Throws<InvalidOperationException>(() => calculator.Calculate());
    }

    [Test]
    public void TestNegativeNumbersAddition()
    {
        var calculator = new Calculator(-5, -6, '+');
        Assert.That(calculator.Calculate(), Is.EqualTo(-11));
    }

    [Test]
    public void TestNegativeNumbersSubtraction()
    {
        var calculator = new Calculator(-5, -6, '-');
        Assert.That(calculator.Calculate(), Is.EqualTo(1));
    }

    [Test]
    public void TestNegativeNumbersMultiplication()
    {
        var calculator = new Calculator(-5, -6, '*');
        Assert.That(calculator.Calculate(), Is.EqualTo(30));
    }

    [Test]
    public void TestNegativeNumbersDivision()
    {
        var calculator = new Calculator(-3, -3, '/');
        Assert.That(calculator.Calculate(), Is.EqualTo(1));
    }

    [Test]
    public void TestMultiplicationByZero()
    {
        var calculator = new Calculator(5, 0, '*');
        Assert.That(calculator.Calculate(), Is.Zero);
    }

    [Test]
    public void TestLargeNumberMultiplication()
    {
        var calculator = new Calculator(1000000, 1000000, '*');
        Assert.That(calculator.Calculate(), Is.EqualTo(1000000000000));
    }

    [Test]
    public void TestDivision_FloatingPointPrecision()
    {
        var calculator = new Calculator(1, 6, '/');
        Assert.That(calculator.Calculate(), Is.EqualTo(0.16666666666).Within(0.001));
    }
}