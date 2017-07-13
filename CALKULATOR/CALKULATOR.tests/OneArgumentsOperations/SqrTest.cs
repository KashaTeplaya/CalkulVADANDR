using CALKULATOR.OneArgumentsOperations;
using CALKULATOR.TwoArgumentsOperations;
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
