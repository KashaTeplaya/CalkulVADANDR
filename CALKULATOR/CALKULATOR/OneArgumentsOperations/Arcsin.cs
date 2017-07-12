using System;

namespace CALKULATOR
{
    public class Arcsin : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Asin(first);
        }
    }
}
