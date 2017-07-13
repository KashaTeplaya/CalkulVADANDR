using CALKULATOR.TwoArgumentsOperations;
using NUnit.Framework;

namespace CALKULATOR.tests.TwoArgumentsOperations
{
    [TestFixture]
    public class MinusTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = new Minus();
            double result = calculator.Calculate(5, 2);
            Assert.AreEqual(3, result);
        }
    }
}
