using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvenChecker.Core;

namespace EvenChecker.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [DataTestMethod]
        [DataRow(2, true)]
        [DataRow(5, false)]
        [DataRow(10, true)]
        [DataRow(7, false)]
        public void IsEven_Parameterized(int number, bool expected)
        {
            // Arrange
            var calc = new Calculator();

            // Act
            bool result = calc.IsEven(number);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
