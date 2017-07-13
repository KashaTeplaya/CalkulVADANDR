
using System;

namespace CALKULATOR.TwoArgumentsOperations
{
    public class Div : ITwoArgumentsCalculator
    {
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
