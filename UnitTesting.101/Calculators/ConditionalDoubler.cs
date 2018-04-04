using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting._101.Calculators
{
    public class ConditionalDoubler : IComputer
    {
        public int DoMathIfSmall(int x)
        {
            if (x <= 100)
                return x * 2;
            return x;
        }

        public int DoMathIfLarge(int x)
        {
            if (x >= 100)
                return x * 2;
            return x;
        }
    }
}
