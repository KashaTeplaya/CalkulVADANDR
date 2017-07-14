using System;

namespace CALKULATOR.OneArgumentsOperations
{
    /// <summary>
    /// class logdva
    /// </summary>
    public class logdva : IOneArgumentsCalculator
    {
        /// <summary>
        /// method logdva
        /// </summary>
        /// <param name="first"></param>
        /// <returns>Log</returns>
        public double Calculate(double first)
        {
            return Math.Log(2*first);
        }
    }
}
