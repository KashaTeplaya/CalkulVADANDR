using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CALKULATOR.OneArgumentsOperations;
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
    }
}
