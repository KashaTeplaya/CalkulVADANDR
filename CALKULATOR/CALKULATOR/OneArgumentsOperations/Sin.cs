using System;

namespace CALKULATOR
{
     public class Sin : IOneArgumentsCalculator
    {
            public double Calculate(double first)
            {
                return  Math.Sin(first) ;
            }
    }
}
