using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALKULATOR
{
    public class Arctg : IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }
    }
}
