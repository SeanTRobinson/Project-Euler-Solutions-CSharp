using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Even_Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int limit = 4000000;

            for (int i = 0, j = 1; j < limit; )
            {
                int next = i + j;
                if (next % 2 == 0) sum += next;
                i = j; j = next;
            }

            Console.WriteLine(sum);
        }
    }
}
