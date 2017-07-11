using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALKULATOR
{
    public class Multy : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}
