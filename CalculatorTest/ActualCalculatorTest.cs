using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class ActualCalculatorTest
    {
        ActualCalculator actual = new ActualCalculator();
        [TestMethod]
        public void TestCalculator()
        {
            double sum = actual.AddTwoNumbers(1, 4);
            double expected = 5;
            Assert.AreEqual(expected, sum);

            double quotient = actual.DivideTwoNumbers(100, 5);
            expected = 20;
            Assert.AreEqual(expected, quotient);

            double product = actual.MultiplyTwoNumbers(5, 18);
            expected = 90;
            Assert.AreEqual(expected, product);
        }
    }
}
