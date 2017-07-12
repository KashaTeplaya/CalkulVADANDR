using System;

namespace CALKULATOR.OneArgumentsOperations
{
    public class Cos : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
