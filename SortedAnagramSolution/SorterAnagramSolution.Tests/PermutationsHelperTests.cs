using System;
using NUnit.Framework;
using SortedAnagramSolution;

namespace SorterAnagramSolution.Tests
{
    [TestFixture]
    public class PermutationsHelperTests
    {
        [TestCase(0, 1d)]
        [TestCase(1, 1d)]
        [TestCase(2,2d)]
        [TestCase(3,6d)]
        [TestCase(10, 3628800d)]
        public void FactorialReturnsCorrectValueWhenInvokedAgainstPositiveIntegerOrZero(int source, double expectedValue)
        {
            //Act
            var result = PermutationsHelper.GetFactorial(source);

            //Assert
            Assert.AreEqual(expectedValue, result, 0.0000000001);
        }

        [TestCase("", 0)]
        [TestCase("a", 1)]
        [TestCase("abc", 6)]
        [TestCase("abcd", 24)]
        [TestCase("aabc", 12)]
        [TestCase("aaabc", 20)]
        [TestCase("aaabc", 20)]
        [TestCase("aabbcc", 90)]
        public void PermutationsCountReturnsCorrectValueWhenInvoked(string source, double expectedValue)
        {
            //Arrange
            var charArray = source.ToCharArray();

            //Act
            var result = PermutationsHelper.GetPermutationsCount(charArray);

            //Assert
            Assert.AreEqual(expectedValue, result, 0.0000000001);
        }
    }
}