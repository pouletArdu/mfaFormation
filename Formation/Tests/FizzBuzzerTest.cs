namespace Tests;

public class UnitTest1
{
     public class FizzBuzzerTest
    {
        [Fact]
        public void ShouldReturn1When1()
        {
            var fizzbuzzer = new FizzBuzzer();
            var result = fizzbuzzer.Get(1);
            Assert.Equal("1",result);
        }
    }
}