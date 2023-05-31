using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class CalcTest
    {
        [Fact]
        public void WhenGivenEmptyStringReturn0()
        {
            // Arrange
            var calc = new Calc();
            var result = calc.Add("");

            Assert.Equal(0,result);
        }

        [Fact]
        public void WhenGiven1gReturn1()
        {
            // Arrange
            var calc = new Calc();
            var result = calc.Add("1");

            Assert.Equal(1,result);
        }

        [Theory]
        [InlineData("1,3",4)]
        [InlineData("1 \n 3",4)]
        public void WhenGivengReturn( string val, int res)
        {
            // Arrange
            var calc = new Calc();
            var result = calc.Add(val);

            Assert.Equal(res,result);
        }
    }
}