using NUnit.Framework;
using SortedAnagramSolution;

namespace SorterAnagramSolution.Tests
{
    [TestFixture]
    public class RankCalculatorTests
    {
        [TestCase("", 0)]
        [TestCase("a", 1d)]
        [TestCase("ba", 2d)]
        [TestCase("cadb", 14d)]
        [TestCase("acdb", 4d)]
        [TestCase("acab", 5d)]
        [TestCase("caba", 11d)]
        [TestCase("aaab", 1d)]
        [TestCase("abab", 2d)]
        [TestCase("baaa", 4d)]
        [TestCase("coolword", 406d)]
        [TestCase("beekeeper", 63d)]
        [TestCase("zoologist", 57649d)]
        [TestCase("jihgfedcba", 3628800d)]
        [TestCase("jiggbbbaaa", 50400d)]
        public void GetRankReturnsCorrectValueWhenInvoked(string source, double expectedValue)
        {
            //Arrange
            var rankCalculator = new RankCalculator();

            //Act
            var result = rankCalculator.GetRank(source);

            //Assert
            Assert.AreEqual(expectedValue, result, 0.0000000001);
        }
    }
}