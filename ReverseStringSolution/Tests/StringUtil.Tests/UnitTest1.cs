using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtil.Core;

namespace StringUtil.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [DataTestMethod]
        [DataRow("hello", "olleh")]
        [DataRow("madam", "madam")]
        [DataRow("abcd", "dcba")]
        public void Reverse_Test(string input, string expected)
        {
            var helper = new StringHelper();

            string result = helper.Reverse(input);

            Assert.AreEqual(expected, result);
        }
    }
}
