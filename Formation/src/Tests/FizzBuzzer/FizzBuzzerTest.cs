namespace Tests;

public class FizzBuzzerTest
{
    FizzBuzzer _fizzBuzzer = new FizzBuzzer();

    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(3, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(15, "FizzBuzz")]
    [InlineData(30, "FizzBuzz")]
    public void ShouldReturnExpectedValue(int input, string output)
    {
        var result = _fizzBuzzer.Get(input);
        Assert.Equal(output, result);
    }

    [Fact]
    public void ShouldReturn1When1()
    {
        var result = _fizzBuzzer.Get(1);
        Assert.Equal("1", result);
    }
}