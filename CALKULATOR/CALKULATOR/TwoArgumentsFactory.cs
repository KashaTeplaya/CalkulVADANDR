using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALKULATOR
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string CalcName)
        {
            switch(CalcName)
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