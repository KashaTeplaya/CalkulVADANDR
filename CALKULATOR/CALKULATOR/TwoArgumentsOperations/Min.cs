using CALKULATOR.OneArgumentsOperations;
using System;

namespace CALKULATOR.TwoArgumentsOperations
{
    /// <summary>
    /// class Min
    /// </summary>
    public class Min : ITwoArgumentsCalculator
    {
        /// <summary>
        /// method min
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>Min</returns>
        public double Calculate(double first, double second)
        {

            return Math.Min(first, second);
          
        }
    }
}

