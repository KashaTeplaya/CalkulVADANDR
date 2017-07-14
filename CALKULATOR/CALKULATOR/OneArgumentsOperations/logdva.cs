using System;

namespace CALKULATOR.OneArgumentsOperations
{
    public class logdva : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(2*first);
        }
    }
}
