using System;

namespace CALKULATOR.OneArgumentsOperations
{
    /// <summary>
    /// class Exponent
    /// </summary>
    public class Exponent : IOneArgumentsCalculator
    {
        /// <summary>
        /// method Exponent
        /// </summary>
        /// <param name="first"></param>
        /// <returns>Exp</returns>
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}
