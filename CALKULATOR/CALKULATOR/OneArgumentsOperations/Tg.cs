using System;

namespace CALKULATOR
{
    public class Tg : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}
