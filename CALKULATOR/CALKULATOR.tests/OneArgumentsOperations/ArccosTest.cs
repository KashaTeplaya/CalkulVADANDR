using CALKULATOR.OneArgumentsOperations;
using CALKULATOR.TwoArgumentsOperations;
using NUnit.Framework;

namespace CALKULATOR.tests.OneArgumentsOperations
{
  public  class ArccosTest
    {
        [TestCase(0, 1.5707)]
        [TestCase(-1, 3.1415)]
        [TestCase(1, 0.0)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Arccos();
            var actualResult = calculator.Calculate(first);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
