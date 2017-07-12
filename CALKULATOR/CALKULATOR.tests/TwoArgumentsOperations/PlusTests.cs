using CALKULATOR.OneArgumentsOperations;
using CALKULATOR.OneArgumentsOperations;
using NUnit.Framework;

namespace CALKULATOR.tests.TwoArgumentsOperations
{
    [TestFixture]
    public class PlusTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = new Plus();
            double result = calculator.Calculate(2,5); 
            Assert.AreEqual(7, result);
        }
    }

}
