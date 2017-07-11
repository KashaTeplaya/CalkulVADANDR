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
                case "button1":
                    return new Plus();
                case "button2":
                    return new Div();
                case "button3":
                    return new Minus();
                case "button4":
                    return new Multy();
                default:
                    throw new Exception("Neizvestnaya operaciya");


            }
        }
       
    }
}