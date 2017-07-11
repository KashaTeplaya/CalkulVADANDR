using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALKULATOR
{
    
    public static class OneArgumentsFactory
    {
        public static IOneArgumentsCalculator CreateCalculator(string CalcName)
        {
            switch (CalcName)
            {
                case "Sin":
                    return new Sin();
                case "Cos":
                    return new Cos();
                case "Tg":
                    return new Tg();
                case "Arctg":
                    return new Arctg();
                case "Arccos":
                    return new Arccos();
                case "Arcsin":
                    return new Arcsin();
                case "Log":
                    return new Log();
                case "Ln":
                    return new Ln();
                case "Kvadrat":
                    return new Kvadrat();
                case "e":
                    return new e();


                default:
                    throw new Exception("Neizvestnaya operaciya");


            }
        }

    }
}

