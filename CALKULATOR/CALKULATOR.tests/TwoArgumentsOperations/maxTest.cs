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
    public class maxTest
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = new Max();
            double result = calculator.Calculate(2, 5);
            Assert.AreEqual(5, result);
        }
    }
}
