using CALKULATOR.OneArgumentsOperations;
using System;

namespace CALKULATOR.TwoArgumentsOperations
{
    /// <summary>
    /// class Max
    /// </summary>
    public class Max : ITwoArgumentsCalculator
    {
        /// <summary>
        /// method Max 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>Max</returns>
        public double Calculate(double first, double second)
        {

            return Math.Max(first, second);

        }
    }
}