using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CALKULATOR.OneArgumentsOperations;
using NUnit.Framework;

namespace CALKULATOR.tests.OneArgumentsOperations
{
   public class ArcsinTest
    {
        [TestCase(0, 0.0)]
        [TestCase(-1, -1.5707)]
        [TestCase(1, 1.5707)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Arcsin();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
