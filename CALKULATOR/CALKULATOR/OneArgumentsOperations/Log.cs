using System;

namespace CALKULATOR.OneArgumentsOperations
{
    /// <summary>
    /// class log
    /// </summary>
    public class Log : IOneArgumentsCalculator
    {
        /// <summary>
        /// method Log
        /// </summary>
        /// <param name="first"></param>
        /// <returns>Log</returns>
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}
