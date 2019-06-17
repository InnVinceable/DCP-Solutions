using NUnit.Framework;
using  _02122018.Solution;

namespace Tests
{
    public class SolutionUnitTests
    {
        [Test]
        [TestCase(17, new int[] { 10, 15, 3, 7 })]
        [TestCase(22, new int[] { 20, 2, 12, 432, 2, -123 })]
        [TestCase(1, new int[] { 5, -2, -4, 12, 46 })]
        [TestCase(-3, new int[] { -1, 12, 23, 64, -2 })]
        public void Solve_GivenArrayWithAnyTwoNumbersThatAddUpToK_ReturnsTrue(int k, int[] inputNumbers)
        {
            Assert.AreEqual(Solution.Solve(k, inputNumbers), true);
        }
        
        [Test]
        [TestCase(41, new int[] { 10, 15, 3, 7 })]
        [TestCase(222, new int[] { 20, 2, 12, 432, 2, -123 })]
        [TestCase(-121, new int[] { 5, -2, -4, 12, 46 })]
        [TestCase(-13, new int[] { -1, 12, 23, 64, -2 })]
        public void Solve_GivenArrayWithNoNumbersThatAddUpToK_ReturnsFalse(int k, int[] inputNumbers)
        {
            Assert.AreEqual(Solution.Solve(k, inputNumbers), false);
        }
    }
}