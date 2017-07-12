using System;

namespace CALKULATOR.OneArgumentsOperations
{
    public class Ln : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log10(first);
        }
    }
}
