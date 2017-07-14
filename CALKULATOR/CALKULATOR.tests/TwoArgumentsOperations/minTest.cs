using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CALKULATOR.TwoArgumentsOperations;
using NUnit.Framework;

namespace CALKULATOR.tests.TwoArgumentsOperations
{
    [TestFixture]
    public class minTest
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = new Min();
            double result = calculator.Calculate(2, 5);
            Assert.AreEqual(2, result);
        }
    }
}
