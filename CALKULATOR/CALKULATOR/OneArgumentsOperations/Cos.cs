using System;

namespace CALKULATOR.OneArgumentsOperations
{
    /// <summary>
    /// class Cos
    /// </summary>
    public class Cos : IOneArgumentsCalculator
    {
        /// <summary>
        /// method Cos
        /// </summary>
        /// <param name="first"></param>
        /// <returns>Cos</returns>
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
