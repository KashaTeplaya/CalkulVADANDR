
using System;

namespace CALKULATOR.TwoArgumentsOperations
{
    /// <summary>
    /// class Div
    /// </summary>
    public class Div : ITwoArgumentsCalculator
    {
        /// <summary>
        /// method Div
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>first/second</returns>
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Делитель не должен быть равен 0");
            }
            return first / second;
        }
    }
}
