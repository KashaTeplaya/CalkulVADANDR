using System;
using CALKULATOR.OneArgumentsOperations;
using CALKULATOR.TwoArgumentsOperations;
using NUnit.Framework;

namespace CALKULATOR.tests.OneArgumentsOperations
{
    public class LnTest
    {
        [TestCase(10, 1)]
        [TestCase(100, 2)]
        [TestCase(1, 0)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Ln();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
        [Test]
        public void ErrorTest()
        {
            var calculator = new Ln();
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
    }
}
