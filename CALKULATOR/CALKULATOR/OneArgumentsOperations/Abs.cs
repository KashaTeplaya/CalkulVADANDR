using System;

namespace CALKULATOR.OneArgumentsOperations
{
    /// <summary>
    /// class Abs
    /// </summary>
    public class Abs : IOneArgumentsCalculator
    {
        /// <summary>
        /// method Abs
        /// </summary>
        /// <param name="first"></param>
        /// <returns>Abs</returns>
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }
    }
}