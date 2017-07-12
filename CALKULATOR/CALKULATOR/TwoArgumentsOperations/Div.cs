namespace CALKULATOR.OneArgumentsOperations
{
    public class Div : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first / second;
        }
    }
}