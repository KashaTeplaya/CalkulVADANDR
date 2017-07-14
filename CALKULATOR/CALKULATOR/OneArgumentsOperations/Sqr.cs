namespace CALKULATOR.OneArgumentsOperations
{
    /// <summary>
    /// class Sqr
    /// </summary>
    public class Sqr : IOneArgumentsCalculator
    {
        /// <summary>
        /// method Sqr
        /// </summary>
        /// <param name="first"></param>
        /// <returns>first*first</returns>
        public double Calculate(double first)
        {
            return first * first;
        }
    }
}
