using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Largest_Prime_Factor
{
    class Program
    {
        static void Main(string[] args)
        {
            long limit = 600851475143;

            long largestFactor = 0;
            try
            {
                largestFactor = PrimeFactors.getLargestPrimeFactor(limit);
            }
            catch(Exception e)
            {
                Console.WriteLine("Failed factorisation: {0}", e.Message);
                return;
                
            }
            Console.WriteLine("Largest prime factor of {0} is {1}", limit, largestFactor);
        } 
    }
}
