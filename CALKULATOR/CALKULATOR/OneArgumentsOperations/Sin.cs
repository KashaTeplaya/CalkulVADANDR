using System;

namespace CALKULATOR.OneArgumentsOperations
{
    /// <summary>
    /// class Sin
    /// </summary>
    public class Sin : IOneArgumentsCalculator
    {
        /// <summary>
        /// method Sin
        /// </summary>
        /// <param name="first"></param>
        /// <returns>Sin</returns>
            public double Calculate(double first)
            {
                return  Math.Sin(first) ;
            }
    }
}
