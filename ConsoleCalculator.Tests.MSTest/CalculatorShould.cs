using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleCalculator.Tests.MSTest
{
    [TestClass]
    public class CalculatorShould
    {
        [TestMethod]
        public void ThrowWhenUnsupported()
        {
            var sut = new Calculator();

            //checking what assertion is being thrown
            Assert.ThrowsException<CalcOpNotSupportedException>( () => sut.Calculate(1,1,"+"));

            //A way to make further assertions with same assert condition.
            var ex = Assert.ThrowsException<CalcOpNotSupportedException>(() => sut.Calculate(1, 1, "+"));
            Assert.AreEqual("+", ex.Operation);
        }
    }
}
