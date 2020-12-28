using System;
using NUnit.Framework;

namespace ConsoleCalculator.Tests.NUnit
{
    public class CalculatorShould
    {
        [Test]
        public void ThrownWhenUnsupported()
        {
            var calculator = new Calculator();

            Assert.That(() => calculator.Calculate(1, 1, "+"), 
                Throws.TypeOf<CalcOpNotSupportedException>()
                .With
                .Property("Operation")
                .EqualTo("+"));
        }
    }
}