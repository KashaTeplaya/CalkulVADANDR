using System;

namespace CALKULATOR.OneArgumentsOperations
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
                    return new Sqr();
                case "e":
                    return new Exponent();
                case "modulX":
                    return new Abs();
                case "minusX":
                    return new MinusX();
                case "desatvX":
                    return new desatvX();
                case "xx":
                    return new DvastepenX();
                case "logdva":
                    return new logdva();
                case "Abs":
                    return new Abs();
                case "delitX":
                    return new desatvX();
                case "Ctan":
                    return new Ctan();

                default:
                    throw new Exception("Unknown operacion");
            }
        }
    }
}

