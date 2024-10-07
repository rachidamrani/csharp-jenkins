using MyClassLibrary;

namespace Project.Tests;

public class CalculatorTests
{
    private readonly Calculator _sut;

    public CalculatorTests()
    {
        _sut = new Calculator();
    }

    [Fact]
    public void AddsTwoNumbers_ReturnsCorrectResult()
    {
        // Arrange
        // Act
        int result = _sut.Add(2, 4);
        // Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void AddsTwoNumbers_ReturnsWrongResult()
    {
        int result = _sut.Add(2, 4);

        Assert.NotEqual(5, result);
    }

    [Fact]
    public void DivideByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => _sut.Divide(2, 0));
    }

    [Theory]
    [InlineData(2, 4, 8)]
    [InlineData(-2, -3, 6)]
    [InlineData(-2, 3, -6)]
    [InlineData(0, 1, 0)]
    public void Multiply_TwoNumbers_ReturnsCorrectResult(int a, int b, int expected)
    {
        int result = _sut.Multiply(a, b);
        Assert.Equal(expected, result);
    }
}
