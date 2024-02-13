using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp
{
    public class Add : ICalc
    {
        public int calculate(int x, int y)
        {
            return x + y;
        }
    }
}
