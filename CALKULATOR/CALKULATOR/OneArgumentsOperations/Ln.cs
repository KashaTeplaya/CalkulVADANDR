using System;

namespace CALKULATOR
{
    public class Ln : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log10(first);
        }
    }
}
