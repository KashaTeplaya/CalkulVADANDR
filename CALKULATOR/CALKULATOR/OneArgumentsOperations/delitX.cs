using System;

namespace CALKULATOR.OneArgumentsOperations
{
    public class delitX : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return 1 / first;
        }
    }
}