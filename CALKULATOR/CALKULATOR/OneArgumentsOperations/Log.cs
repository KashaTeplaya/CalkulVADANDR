using System;

namespace CALKULATOR.OneArgumentsOperations
{
    public class Log : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}
