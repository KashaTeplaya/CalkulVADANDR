using CALKULATOR.OneArgumentsOperations;
using NUnit.Framework;

namespace CALKULATOR.tests.OneArgumentsOperations
{
   public class CosTest
    {
        [TestCase(0, 1)]
        [TestCase(3, -0.98999)]
        [TestCase(-7, 0.7539)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Cos();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
