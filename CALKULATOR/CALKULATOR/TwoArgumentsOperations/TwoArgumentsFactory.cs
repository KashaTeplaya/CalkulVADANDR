using System;

namespace CALKULATOR.OneArgumentsOperations
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
               
                default:
                    throw new Exception("Neizvestnaya operaciya");
            }
        }
    }
}