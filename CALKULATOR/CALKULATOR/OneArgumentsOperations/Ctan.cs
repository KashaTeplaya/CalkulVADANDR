using System;

namespace CALKULATOR.OneArgumentsOperations
{
    public class Ctan: IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cosh(first);
        }
    }
}