using System;

namespace CALKULATOR.OneArgumentsOperations
{
    /// <summary>
    /// class Atan
    /// </summary>
    public class Arctg : IOneArgumentsCalculator
    {
        /// <summary>
        /// method Atan
        /// </summary>
        /// <param name="first"></param>
        /// <returns>Atan</returns>
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}
