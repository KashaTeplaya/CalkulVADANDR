using System;

namespace CALKULATOR.OneArgumentsOperations
{
    /// <summary>
    /// class delitX
    /// </summary>
    public class delitX : IOneArgumentsCalculator
    {
        /// <summary>
        /// method delitX
        /// </summary>
        /// <param name="first"></param>
        /// <returns>1/first</returns>
        public double Calculate(double first)
        {
            return 1 / first;
        }
    }
}