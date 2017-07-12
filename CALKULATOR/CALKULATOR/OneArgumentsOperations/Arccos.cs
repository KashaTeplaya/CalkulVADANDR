using System;

namespace CALKULATOR
{
    public class Arccos : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Acos(first);
        }
    }
}
