
namespace CALKULATOR.TwoArgumentsOperations
{
    /// <summary>
    /// class Multyply
    /// </summary>
    public class Multyply : ITwoArgumentsCalculator
    {
        /// <summary>
        /// method Multyply
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>first*second</returns>
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}
