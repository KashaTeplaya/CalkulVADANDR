using System;

namespace CALKULATOR.OneArgumentsOperations
{
    public class Abs : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }
    }
}