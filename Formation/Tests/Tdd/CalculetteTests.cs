using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd
{
    public class CalculetteTests
    {
        Calculette calculette = new Calculette();

        [Theory]
        [InlineData("", 0)]
        [InlineData("1", 1)]
        [InlineData("1,2", 3)]
        [InlineData("1,2,3", 6)]
        public void ShouldAdd(string input, int expected)
        {
            var result = calculette.Add(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldReturnExceptionWhenNegative() 
        {
            Exception exception = null;
            try
            {
                calculette.Add("-1");
            }
            catch (Exception e)
            {
                exception = e;
            }
            Assert.Equal(typeof(Exception), exception.GetType());
        }
    }
}
