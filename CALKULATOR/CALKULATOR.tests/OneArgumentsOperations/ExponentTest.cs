using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CALKULATOR.OneArgumentsOperations;
using NUnit.Framework;

namespace CALKULATOR.tests.OneArgumentsOperations
{
   public class ExponentTest
    {
        [TestCase(0, 1)]
        [TestCase(-1, 0.3678)]
        [TestCase(1, 2.7182)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Exponent();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
