using System;
using CALKULATOR.OneArgumentsOperations;
using CALKULATOR.TwoArgumentsOperations;
using NUnit.Framework;

namespace CALKULATOR.tests.FactoryTest
{
    public class OneArgumentFacroryTest
    {
        [TestCase("Arccos", typeof(Arccos))]
        [TestCase("Arcsin", typeof(Arcsin))]
        [TestCase("Arctg", typeof(Arctg))]
        [TestCase("Cos", typeof(Cos))]
        [TestCase("e", typeof(Exponent))]
        [TestCase("Ln", typeof(Ln))]
        [TestCase("Log", typeof(Log))]
        [TestCase("Sin", typeof(Sin))]
        [TestCase("Kvadrat", typeof(Sqr))]
        [TestCase("Tg", typeof(Tg))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }
}
