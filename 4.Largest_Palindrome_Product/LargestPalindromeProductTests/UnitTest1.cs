using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4.Largest_Palindrome_Product;

namespace LargestPalindromeProductTests
{
    [TestClass]
    public class LargestPalindromeProductTest
    {
        [TestMethod]
        public void LargestPalindromicProduct_ReturnsLPP_ForSmallLowRange()
        {
            int expectedProduct = 9;
            int actualProduct = LargestPalindromeProduct.LargestPalindromicProduct(1, 5);
            Assert.AreEqual(expectedProduct, actualProduct, "Largest palindromic product between 5 and 5 should be 9");
        }

        [TestMethod]
        public void LargestPalindromicProduct_Returns0_With2NegativeNums()
        {
            int expectedProduct = 0;
            int actualProduct = LargestPalindromeProduct.LargestPalindromicProduct(-1, -5);
            Assert.AreEqual(expectedProduct, actualProduct, "Largest palindromic product between -1 and -5 should be 0");
        }

        [TestMethod]
        public void LargestPalindromicProduct_ReturnsLPP_With1NegativeNum()
        {
            int expectedProduct = 9;
            int actualProduct = LargestPalindromeProduct.LargestPalindromicProduct(-1, 5);
            Assert.AreEqual(expectedProduct, actualProduct, "Largest palindromic product between -1 and 5 should be 9");
        }

        [TestMethod]
        public void LargestPalindromicProduct_ReturnsLPP_For3DigitNumsRange()
        {
            int expectedProduct = 906609;
            int actualProduct = LargestPalindromeProduct.LargestPalindromicProduct(100, 999);
            Assert.AreEqual(expectedProduct, actualProduct, "Largest palindromic product between 100 and 999 should be 906609");
        }
        
        [TestMethod]
        public void isPalindrome_IsTrue_ForPositiveSingleDigit()
        {
            int entry = 1;
            Assert.IsTrue(LargestPalindromeProduct.isPalindrome(entry), "{0} is a palindrome");
        }

        [TestMethod]
        public void isPalindrome_IsFalse_ForNegativeSingleDigit()
        {
            int entry = -1;
            Assert.IsFalse(LargestPalindromeProduct.isPalindrome(entry), "{0} is not a palindrome");
        }

        [TestMethod]
        public void isPalindrome_IsTrue_ForZero()
        {
            int entry = 0;
            Assert.IsTrue(LargestPalindromeProduct.isPalindrome(entry), "{0} is a palindrome");
        }

        [TestMethod]
        public void isPalindrome_IsTrue_ForMultipleDigitPalindrome()
        {
            int entry = 1001;
            Assert.IsTrue(LargestPalindromeProduct.isPalindrome(entry), "{0} is a palindrome");
        }

        [TestMethod]
        public void resultExceedsUpperLimit_IsTrue_WhenDivIsSmallEnough()
        {
            int entry = 357;
            int div = 3;
            int upper = 100;
            Assert.IsTrue(LargestPalindromeProduct.resultExceedsUpperLimit(entry, div, upper), 
                "{0}*{1} should be < {2}", entry, div, upper);
        }

        [TestMethod]
        public void resultExceedsUpperLimit_IsFalse_WhenDivIsLargeEnough()
        {
            int entry = 357;
            int div = 4;
            int upper = 100;
            Assert.IsFalse(LargestPalindromeProduct.resultExceedsUpperLimit(entry, div, upper),
                "{0}*{1} should be > {2}", entry, div, upper);
        }
    }
}
