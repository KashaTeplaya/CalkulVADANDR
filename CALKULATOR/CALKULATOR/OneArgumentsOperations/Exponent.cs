using System;

namespace CALKULATOR
{
    public class e : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}
