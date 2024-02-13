using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace CalcApp
{
    internal class GetCalcType : ICalcTypeFactory
    {
        public ICalc getCalcType(int calcType)
        {
            switch (calcType)
            {
                case 1:
                    {
                        return new Add();
                        break;
                    }
                case 2:
                    {
                        return new Sub();
                        break;
                    }
                default:
                    return new Sub();
                    break;
            }
        }
    }
}
