using System;

namespace CALKULATOR.OneArgumentsOperations
{
    public class MinusX: IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return -first;
        }
        
    }
}