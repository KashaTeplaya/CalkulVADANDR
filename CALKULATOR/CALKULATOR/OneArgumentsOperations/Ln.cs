using System;

namespace CALKULATOR.OneArgumentsOperations
{
    /// <summary>
    /// class Ln
    /// </summary>
    public class Ln : IOneArgumentsCalculator
    {
        /// <summary>
        /// method Ln
        /// </summary>
        /// <param name="first"></param>
        /// <returns>Log10</returns>
        public double Calculate(double first)
        {
            if (first == 0)
            {
                throw new Exception("Вводимое не должно быть 0");
            }
            return Math.Log10(first);
        }
    }
}
