using System;

namespace CALKULATOR.OneArgumentsOperations
{
     public class Sin : IOneArgumentsCalculator
    {
            public double Calculate(double first)
            {
                return  Math.Sin(first) ;
            }
    }
}
