using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALKULATOR
{
    public class Tg : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}
