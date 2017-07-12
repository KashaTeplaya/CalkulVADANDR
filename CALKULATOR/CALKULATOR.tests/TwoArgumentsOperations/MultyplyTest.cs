using CALKULATOR.OneArgumentsOperations;
using NUnit.Framework;

namespace CALKULATOR.tests.TwoArgumentsOperations
{
    [TestFixture]
    public class MultyplyTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = new Multyply();
            double result = calculator.Calculate(2, 5);
            Assert.AreEqual(10, result);
        }
    }
}