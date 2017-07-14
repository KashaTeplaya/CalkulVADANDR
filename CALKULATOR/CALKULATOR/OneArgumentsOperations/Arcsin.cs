using System;

namespace CALKULATOR.OneArgumentsOperations
{
    /// <summary>
    /// class Arcsin 
    /// </summary>
    public class Arcsin : IOneArgumentsCalculator
    {
        /// <summary>
        /// method Asin
        /// </summary>
        /// <param name="first"></param>
        /// <returns>Asin</returns>
        public double Calculate(double first)
        {
            return Math.Asin(first);
        }
    }
}
