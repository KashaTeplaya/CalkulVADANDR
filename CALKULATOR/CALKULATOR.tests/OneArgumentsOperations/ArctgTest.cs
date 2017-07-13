using CALKULATOR.OneArgumentsOperations;
using CALKULATOR.TwoArgumentsOperations;
using NUnit.Framework;

namespace CALKULATOR.tests.OneArgumentsOperations
{
  public  class ArctgTest
    {
        [TestCase(0, 0.0)]
        [TestCase(-1, -0.78539)]
        [TestCase(1, 0.7853)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Arctg();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
