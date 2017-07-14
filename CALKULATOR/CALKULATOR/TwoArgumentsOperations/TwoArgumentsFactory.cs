using System;

namespace CALKULATOR.TwoArgumentsOperations
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch(calculatorName)
            {
                case "Plus":
                    return new Plus();
                case "Div":
                    return new Div();
                case "Minus":
                    return new Minus();
                case "Multiply":
                    return new Multyply();
                case "max":
                    return new Max();
                case "min":
                    return new Min();
                case "stependrob":
                    return new stependrobcs();

                default:
                    throw new Exception("Neizvestnaya operaciya");
            }
        }
    }
}