using System;

namespace CALKULATOR.OneArgumentsOperations
{
    public class Arctg : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}
