using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CALKULATOR.OneArgumentsOperations;
using NUnit.Framework;

namespace CALKULATOR.tests.OneArgumentsOperations
{
   public class TgTest
    {
        [TestCase(0, 0.0001)]
        [TestCase(-1, -1.5574)]
        [TestCase(1, 1.5574)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Tg();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
