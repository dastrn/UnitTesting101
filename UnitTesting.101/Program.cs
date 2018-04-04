using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting._101.Calculators;
using UnitTesting._101Tests.Services;

namespace UnitTesting._101
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new MathService(new ConditionalDoubler());
            bool loop = true;
            while(loop)
            {
                Console.WriteLine("Enter a number to continue: ");
                var next = Console.ReadLine() ?? "";
                if (next.Length == 0)
                {
                    loop = false;
                }
                else DoMath(next, service);
            }
            
        }

        private static void DoMath(string args, MathService service)
        {
            var result = service.DoMath(Convert.ToInt32(args), false);
            Console.WriteLine(result);

        }
    }
}
