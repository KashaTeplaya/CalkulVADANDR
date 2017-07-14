
namespace CALKULATOR.TwoArgumentsOperations
{
    /// <summary>
    /// class Minus 
    /// </summary>
    public class Minus : ITwoArgumentsCalculator
    {
        /// <summary>
        /// method Minus
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>first-second</returns>
        public double Calculate(double first,double second)
        {
            return first - second;
        }
    }
}