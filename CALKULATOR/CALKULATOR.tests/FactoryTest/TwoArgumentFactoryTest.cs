using System;

using CALKULATOR.OneArgumentsOperations;
using NUnit.Framework;

namespace CALKULATOR.tests.FactoryTest
{
   public class TwoArgumentFactoryTest
    {
        [TestCase("Plus", typeof(Plus))]
        [TestCase("Minus", typeof(Minus))]
        [TestCase("Div", typeof(Div))]
        [TestCase("Multyply", typeof(Multyply))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
