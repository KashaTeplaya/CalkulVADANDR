using System;

namespace CALKULATOR.OneArgumentsOperations
{
    /// <summary>
    /// class Ctan
    /// </summary>
    public class Ctan: IOneArgumentsCalculator
    {
        /// <summary>
        /// method 
        /// </summary>
        /// <param name="first"></param>
        /// <returns>Tanh</returns>
        public double Calculate(double first)
        {
            return Math.Tanh(first);
        }
    }
}