using System;

namespace CALKULATOR.OneArgumentsOperations
{
    public class DvastepenX : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(2,first);
        }
    }
}