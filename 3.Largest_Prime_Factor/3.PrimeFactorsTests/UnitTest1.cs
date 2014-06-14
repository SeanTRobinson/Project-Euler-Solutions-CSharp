using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3.Largest_Prime_Factor;

namespace _3.PrimeFactorsTests
{
    [TestClass]
    public class PrimeFactorTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void getLargestPrimeFactor_ThrowsException_ForZero()
        {
            long factor = PrimeFactors.getLargestPrimeFactor(0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void getLargestPrimeFactor_ThrowsException_ForNegative()
        {
            long factor = PrimeFactors.getLargestPrimeFactor(-1);
        }

        [TestMethod]
        public void getLargestPrimeFactor_ReturnsNumber_ForPrime()
        {
            long factor = PrimeFactors.getLargestPrimeFactor(5);
            Assert.AreEqual(factor, 5, "Largest prime factor of prime should be that prime.");
        }

        [TestMethod]
        public void getLargestPrimeFactor_ReturnsLPF_ForSmallNumber()
        {
            long factor = PrimeFactors.getLargestPrimeFactor(9);
            Assert.AreEqual(factor, 3, "Largest prime factor of 9 should be 3.");
        }

        [TestMethod]
        public void getLargestPrimeFactor_ReturnsLPF_ForMediumNumber()
        {
            long factor = PrimeFactors.getLargestPrimeFactor(978);
            Assert.AreEqual(factor, 163, "Largest prime factor of 978 should be 163.");
        }

        [TestMethod]
        public void getLargestPrimeFactor_ReturnsLPF_ForMaxNumber()
        {
            long factor = PrimeFactors.getLargestPrimeFactor(999999999999999);
            Assert.AreEqual(factor, 2906161, "Largest prime factor of 999999999999999 should be 2906161.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void getLargestPrimeFactor_ThrowsException_ForLargerThanMaxNumber()
        {
            long factor = PrimeFactors.getLargestPrimeFactor(1000000000000000);
        }
    }
}
