using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumN.Core;

namespace SumN.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [DataTestMethod]
        [DataRow(10, 55)]
        [DataRow(12, 78)]
        [DataRow(5, 15)]
        public void SumOfN_Test(int n, int expected)
        {
            var calc = new Calculator();

            int result = calc.SumOfN(n);

            Assert.AreEqual(expected, result);
        }
    }
}
