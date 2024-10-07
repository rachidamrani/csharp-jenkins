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

    [Fact]
    public void MultiplyByZero_ReturnsZero()
    {
        int result = _sut.Multiply(2, 0);
        Assert.Equal(0, result);
    }
}
