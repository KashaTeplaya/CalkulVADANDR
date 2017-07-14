using System;

namespace CALKULATOR.OneArgumentsOperations
{
    /// <summary>
    /// class minusX
    /// </summary>
    public class MinusX: IOneArgumentsCalculator
    {
        /// <summary>
        /// method MinusX
        /// </summary>
        /// <param name="first"></param>
        /// <returns>-first</returns>
        public double Calculate(double first)
        {
            return -first;
        }
        
    }
}