using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CALKULATOR.OneArgumentsOperations;
using NUnit.Framework;

namespace CALKULATOR.tests.OneArgumentsOperations
{
   public class delitXTest
    {
        [TestCase(1,1)]
        [TestCase(2, 0.5)]
        [TestCase(4, 0.25)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new delitX();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
