using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Multiples_Of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 1000;
            List<int> factors = new List<int>();
            factors.AddRange(getSumOfMultiples(3, limit));
            factors.AddRange(getSumOfMultiples(5, limit));

            Console.WriteLine(factors.ToArray().Distinct().Sum());
        }

        private static List<int> getSumOfMultiples(int factor, int limit)
        {
            List<int> factors = new List<int>();
            for (int i = factor; i < limit; i= i+factor)
            {
                factors.Add(i);
            }
            return factors;
        }
    }
}
