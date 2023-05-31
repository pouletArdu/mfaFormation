namespace Tdd
{
    internal class Fizzbuzzer
    {
        internal string Get(int v)
        {
            var result = string.Empty;
            if (v % 3 == 0) result +=  "Fizz";
            if (v % 5 == 0) result += "Buzz";           
            if(string.IsNullOrEmpty(result))  return v.ToString();

            return result;
        }

        internal string GetList()
        {
            List<int> nombres = Enumerable.Range(1, 100).ToList();
            return string.Join("", nombres.Select(Get));
        }
    }
}
