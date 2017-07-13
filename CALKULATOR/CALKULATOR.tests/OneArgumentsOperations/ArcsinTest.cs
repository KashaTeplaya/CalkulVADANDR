using CALKULATOR.OneArgumentsOperations;
using CALKULATOR.TwoArgumentsOperations;
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
