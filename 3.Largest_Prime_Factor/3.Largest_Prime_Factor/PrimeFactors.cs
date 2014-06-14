using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Largest_Prime_Factor
{
    public class PrimeFactors
    {
        const long max = 999999999999999;

        public static long getLargestPrimeFactor(long limit)
        {
            validateLimit(limit);

            List<long> primeFactors = getPrimeFactors(limit);
            primeFactors.Sort();
            return primeFactors.Max();
        }

        public static List<long> getPrimeFactors(long limit)
        {
            validateLimit(limit);

            List<long> primeFactors = new List<long>();
            int div = 2;

            while (limit > 1)
            {
                while (limit % div == 0)
                {
                    primeFactors.Add(div);
                    limit /= div;
                }
                div++;
                if (div * div > limit)
                {
                    if (limit > 1)
                    {
                        primeFactors.Add(limit);
                        break;
                    }
                }
            }

            return primeFactors;
        }

        private static void validateLimit(long limit)
        {
            if (limit <= 0)
            {
                throw new ArgumentException("This class does not support 0 or negative prime factorisation.");
            }

            if (limit > max)
            {
                String exString = String.Format("{0} is higher than max {1}", limit, max);
                throw new ArgumentException(exString);
            }
        }
    }
}
