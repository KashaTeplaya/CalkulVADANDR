using System;

namespace CALKULATOR.OneArgumentsOperations
{
    public class Tg : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}
