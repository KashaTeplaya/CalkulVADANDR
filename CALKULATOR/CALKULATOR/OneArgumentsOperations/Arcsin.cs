using System;

namespace CALKULATOR.OneArgumentsOperations
{
    public class Arcsin : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Asin(first);
        }
    }
}
