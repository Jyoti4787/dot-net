using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcUnitTesting.Core;

namespace CalculatorTestProj
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add_Test()
        {
            Calculator calc = new Calculator();
            int result = calc.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        // ✅ Parameterized Test
        [DataTestMethod]
        [DataRow(2, 1, 3)]
        [DataRow(11, 1, 12)]
        public void Add_Parameterized(int a, int b, int expected)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
