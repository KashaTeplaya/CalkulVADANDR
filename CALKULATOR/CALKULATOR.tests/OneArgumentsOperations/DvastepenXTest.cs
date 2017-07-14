using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CALKULATOR.OneArgumentsOperations;
using NUnit.Framework;

namespace CALKULATOR.tests.OneArgumentsOperations
{
    public class DvastepenXTest
    {
        [TestCase(1,2)]
        [TestCase(0, 1)]
        [TestCase(2, 4)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new DvastepenX();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
