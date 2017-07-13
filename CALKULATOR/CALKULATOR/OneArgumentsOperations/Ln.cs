using System;

namespace CALKULATOR.OneArgumentsOperations
{
    public class Ln : IOneArgumentsCalculator
    {
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
