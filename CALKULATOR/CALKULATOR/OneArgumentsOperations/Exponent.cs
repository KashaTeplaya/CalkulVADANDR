using System;

namespace CALKULATOR.OneArgumentsOperations
{
    public class Exponent : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}
