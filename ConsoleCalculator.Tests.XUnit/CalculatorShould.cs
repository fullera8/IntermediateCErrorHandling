using System;
using Xunit;

namespace ConsoleCalculator.Tests.XUnit
{
    public class CalculatorShould
    {
        [Fact]
        public void Test1()
        {
            var calculator = new Calculator();

            //assert the specific derived class
            Assert.Throws<CalcOpNotSupportedException>(() => calculator.Calculate(1,1,"+"));

            //Check the base class
            Assert.ThrowsAny<CalculationException>(() => calculator.Calculate(1,1,"+"));

            //Check the properties
            var ex = Assert.Throws<CalcOpNotSupportedException>(() => calculator.Calculate(1, 1, "+"));
            Assert.Equal("+", ex.Operation);
        }
    }
}
