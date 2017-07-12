using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CALKULATOR.OneArgumentsOperations;
using NUnit.Framework;

namespace CALKULATOR.tests.OneArgumentsOperations
{
   public class SqrTest
    {
        [TestCase(0, 0)]
        [TestCase(2, 4)]
        [TestCase(1, 1)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Sqr();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
