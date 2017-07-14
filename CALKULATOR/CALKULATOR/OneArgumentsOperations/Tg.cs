using System;

namespace CALKULATOR.OneArgumentsOperations
{
    /// <summary>
    /// class Tg
    /// </summary>
    public class Tg : IOneArgumentsCalculator
    {
        /// <summary>
        /// method Tg
        /// </summary>
        /// <param name="first"></param>
        /// <returns>Tg</returns>
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}
