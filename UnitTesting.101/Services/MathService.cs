using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting._101.Calculators;

namespace UnitTesting._101Tests.Services
{
    public class MathService
    {
        private IComputer computer;

        public MathService(IComputer computer)
        {
            this.computer = computer;
        }

        public int DoMath(int x, bool applyLargeRule)
        {
            if (applyLargeRule)
                return computer.DoMathIfLarge(x);
            return computer.DoMathIfSmall(x);
        }
    }
}
