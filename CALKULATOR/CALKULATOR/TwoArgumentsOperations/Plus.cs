
namespace CALKULATOR.TwoArgumentsOperations
{
    /// <summary>
    /// class Plus
    /// </summary>
    public class Plus : ITwoArgumentsCalculator
    {
        /// <summary>
        /// method Plus
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>first+second</returns>
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}