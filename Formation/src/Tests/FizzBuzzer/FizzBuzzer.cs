namespace Tests;

internal class FizzBuzzer
{
    internal string Get(int v)
    {
        var result = string.Empty;

        if (v % 3 == 0) result += "Fizz";
        if (v % 5 == 0) result += "Buzz";

        if (string.IsNullOrEmpty(result))
        {
            result += v.ToString();
        }

        return result;
    }
}