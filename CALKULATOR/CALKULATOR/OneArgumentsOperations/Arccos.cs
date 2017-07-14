using System;

namespace CALKULATOR.OneArgumentsOperations
{
    /// <summary>
    /// class Arccos
    /// </summary>
    public class Arccos : IOneArgumentsCalculator
    {
        /// <summary>
        /// method Acos
        /// </summary>
        /// <param name="first"></param>
        /// <returns>Acos</returns>
        public double Calculate(double first)
        {
            return Math.Acos(first);
        }
    }
}
