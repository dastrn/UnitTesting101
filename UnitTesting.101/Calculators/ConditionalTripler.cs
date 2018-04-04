using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting._101.Calculators
{
    public class ConditionalTripler : IComputer
    {
        public int DoMathIfSmall(int x)
        {
            if (x <= 10)
                return x * 3;
            return x;
        }

        public int DoMathIfLarge(int x)
        {
            if (x >= 10)
                return x * 3;
            return x;
        }
    }
}
