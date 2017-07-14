using System;

namespace CALKULATOR.OneArgumentsOperations
{
    /// <summary>
    /// class DvastepenX
    /// </summary>
    public class DvastepenX : IOneArgumentsCalculator
    {
        /// <summary>
        /// method DvastepenX
        /// </summary>
        /// <param name="first"></param>
        /// <returns>Pow(2,first)</returns>
        public double Calculate(double first)
        {
            return Math.Pow(2,first);
        }
    }
}