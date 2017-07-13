using CALKULATOR.OneArgumentsOperations;
using CALKULATOR.TwoArgumentsOperations;
using NUnit.Framework;

namespace CALKULATOR.tests.OneArgumentsOperations
{
    public class LogTest
    {
        [TestCase(4, 1.38629)]
        [TestCase(6, 1.7917)]
        [TestCase(10, 2.3025)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Log();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
