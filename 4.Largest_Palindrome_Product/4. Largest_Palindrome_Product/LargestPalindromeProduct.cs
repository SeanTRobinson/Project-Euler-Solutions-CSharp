using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Largest_Palindrome_Product
{
    public static class LargestPalindromeProduct
    {
        public static int LargestPalindromicProduct(int lowerLimit, int upperLimit)
        {
            return getLargest(lowerLimit, upperLimit);
        }

        private static int getLargest(int lowerLimit, int upperLimit)
        {
            int maxProduct = upperLimit * upperLimit;
            int minProduct = lowerLimit * lowerLimit;
            for( int i=maxProduct; i>lowerLimit; i--)
            {
                if (isPalindromicProduct(i, lowerLimit, upperLimit))
                {
                    return i;
                }
            }
            return 0;
        }

        private static bool isPalindromicProduct(int entry, int lower, int upper)
        {
            if (!isPalindrome(entry))
            {
                return false;
            }
            if(hasFactorsInCorrectRange(entry, lower, upper))
            {
                return true;
            }
            return false;
        }

        public static bool isPalindrome(int entry)
        {
            string numString = entry.ToString();
            string reverseNumString = new string(numString.ToCharArray().Reverse().ToArray());
            return (numString.Equals(reverseNumString)) ? true : false;
        }

        private static bool hasFactorsInCorrectRange(int entry, int lower, int upper)
        { 
            for(int i=upper; i>lower; i--)
            {
                if (resultExceedsUpperLimit(entry, i, upper)) return false;
                if (entry % i == 0) return true;
            }
            return false;
        }

        public static bool resultExceedsUpperLimit(int entry, int i, int upper)
        {
            return ((float)entry / (float)i > upper) ? true : false;
        }
    }
}
