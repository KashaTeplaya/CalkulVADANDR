using System;

namespace CALKULATOR
{
    public class Log : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}
