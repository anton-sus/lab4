using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести целое число N > 0");
            int N = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int n = 1; n <= N; n++)
            {
                s += 2 * n - 1;
                Console.WriteLine("квадрат {0} = {1}", n, s);
            }
            Console.ReadKey();
        }
    }
}
