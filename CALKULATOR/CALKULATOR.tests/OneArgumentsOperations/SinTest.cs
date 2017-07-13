using CALKULATOR.OneArgumentsOperations;
using NUnit.Framework;
using CALKULATOR.TwoArgumentsOperations;

namespace CALKULATOR.tests.OneArgumentsOperations
{
    public class SinTest
    {
        [TestCase(0, 0)]
        [TestCase(3, 0.1411)]
        [TestCase(-7, -0.6569)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Sin();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult,0.0001);
        }
    }
}
