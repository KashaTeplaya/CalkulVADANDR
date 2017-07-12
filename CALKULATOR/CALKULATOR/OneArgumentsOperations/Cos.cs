using System;

namespace CALKULATOR
{
    public class Cos : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
