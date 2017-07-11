using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALKULATOR
{
    public class Kvadrat : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return (first*first);
        }
    }
}
