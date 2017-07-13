
namespace CALKULATOR.TwoArgumentsOperations
{
    public class Plus : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}