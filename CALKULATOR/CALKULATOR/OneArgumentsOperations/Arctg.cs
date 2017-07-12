using System;

namespace CALKULATOR
{
    public class Arctg : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}
