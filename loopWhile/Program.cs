using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            double S = 1000;
            double s2 = 2 * S;
            double p = 4;
            int y = 0;
            while (S < s2)

            {
                S += S * 4 / 100;
                y++;
            }
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
