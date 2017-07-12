using System;

namespace CALKULATOR.OneArgumentsOperations
{
    public class Arccos : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Acos(first);
        }
    }
}
