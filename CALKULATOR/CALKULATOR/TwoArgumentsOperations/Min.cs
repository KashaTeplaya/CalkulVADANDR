using CALKULATOR.OneArgumentsOperations;
using System;

namespace CALKULATOR.TwoArgumentsOperations
{
    public class Min : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {

            return Math.Min(first, second);
          
        }
    }
}

