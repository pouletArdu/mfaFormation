using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd
{
    public class FizzBuzzerTest
    {
        Fizzbuzzer fizzbuzzer = new Fizzbuzzer();

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void ShouldReturnExpectedValue(int input, string expected)
        {
            var result = fizzbuzzer.Get(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldReturnCorrectValue()
        {
            var result = fizzbuzzer.GetList();
            Assert.Equal("12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz1617Fizz19BuzzFizz2223FizzBuzz26Fizz2829FizzBuzz3132Fizz34BuzzFizz3738FizzBuzz41Fizz4344FizzBuzz4647Fizz49BuzzFizz5253FizzBuzz56Fizz5859FizzBuzz6162Fizz64BuzzFizz6768FizzBuzz71Fizz7374FizzBuzz7677Fizz79BuzzFizz8283FizzBuzz86Fizz8889FizzBuzz9192Fizz94BuzzFizz9798FizzBuzz", result);
        }
    }
}
