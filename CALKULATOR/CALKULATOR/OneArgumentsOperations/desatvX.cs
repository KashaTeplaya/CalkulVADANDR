using System;

namespace CALKULATOR.OneArgumentsOperations
{
    /// <summary>
    /// class desatvX
    /// </summary>
    public class desatvX : IOneArgumentsCalculator
    {
        /// <summary>
        /// method desatvX
        /// </summary>
        /// <param name="first"></param>
        /// <returns>Pow(10,first)</returns>
        public double Calculate(double first)
        {
            return Math.Pow(10, first);
        }
    }
}