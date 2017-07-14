using CALKULATOR.OneArgumentsOperations;
using System;

namespace CALKULATOR.TwoArgumentsOperations
{
    public class stependrobcs : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {

            return Math.Pow(first, 1 / second);

        }
    }
}