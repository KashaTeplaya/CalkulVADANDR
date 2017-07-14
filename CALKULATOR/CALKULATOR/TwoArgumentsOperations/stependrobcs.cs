using CALKULATOR.OneArgumentsOperations;
using System;

namespace CALKULATOR.TwoArgumentsOperations
{
    /// <summary>
    /// class stependrob
    /// </summary>
    public class Stependrobcs : ITwoArgumentsCalculator
    {
        /// <summary>
        /// method stependrobcs
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>Pow</returns>
        public double Calculate(double first, double second)
        {

            return Math.Pow(first, 1 / second);

        }
    }
}