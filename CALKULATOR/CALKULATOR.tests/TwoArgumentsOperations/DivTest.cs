using System;
using CALKULATOR.TwoArgumentsOperations;
using NUnit.Framework;

namespace CALKULATOR.tests.TwoArgumentsOperations
{
    [TestFixture]
    public class DivTest
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = new Div();
            double result = calculator.Calculate(10, 5);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void ErrorTest()
        {
            var calculator = new Div();
            Assert.Throws<Exception>(() => calculator.Calculate(-5, 0));
        }

    }
}