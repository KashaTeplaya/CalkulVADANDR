using System;

namespace CALKULATOR.OneArgumentsOperations
{
    public class desatvX : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(10, first);
        }
    }
}