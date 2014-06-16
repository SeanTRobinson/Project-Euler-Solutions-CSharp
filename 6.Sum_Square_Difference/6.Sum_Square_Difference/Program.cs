using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//25164150

namespace _6.Sum_Square_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateDiff(100);
        }

        private static void CalculateDiff(int limit)
        {
            int sum = 0, sumOfSquares = 0;
            for (int i = 1; i <= limit; i++)
            {
                sum += i;
                sumOfSquares += (i * i);
            }

            int squareOfSum = (sum * sum);
            int diff = (squareOfSum - sumOfSquares);
            Console.WriteLine("Difference between {0} and {1}: {2}", squareOfSum, sumOfSquares, diff);
        }
    }
}
