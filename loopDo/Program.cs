using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopDo
{
    class Program
    {
        static void Main(string[] args)
        {
            double S = 1000;
            double s2 = 2 * S;
            double p = 4;
            int y = 0;
            do

            {
                S += S * 4 / 100;
                y++;
            } while (S < s2);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
