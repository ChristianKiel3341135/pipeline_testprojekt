namespace github_pipeline_testprojekt;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsSum()
    {
        var calculator = new Calculator();
        int result = calculator.Add(3, 5);
        Assert.Equal(8, result);
    }

    [Fact]
    public void Subtract_TwoNumbers_ReturnsDifference()
    {
        var calculator = new Calculator();
        int result = calculator.Subtract(10, 4);
        Assert.Equal(6, result);
    }

    [Fact]
    public void Multiply_TwoNumbers_ReturnsProduct()
    {
        var calculator = new Calculator();
        int result = calculator.Multiply(4, 6);
        Assert.Equal(24, result);
    }

    [Fact]
    public void Divide_ValidNumbers_ReturnsQuotient()
    {
        var calculator = new Calculator();
        int result = calculator.Divide(20, 5);
        Assert.Equal(4, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        var calculator = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
    }
}

public class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;

    public int Divide(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException();
        return a / b;
    }
}
