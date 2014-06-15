using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Largest_Palindrome_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            GetLargestPalindromicProduct(100, 999);            
        }

        private static void GetLargestPalindromicProduct(int p1, int p2)
        {
            Console.WriteLine("Largest palindromic product in range {0} to {1} is {2}", p1, p2, LargestPalindromeProduct.LargestPalindromicProduct(p1, p2));
        }
    }
}
