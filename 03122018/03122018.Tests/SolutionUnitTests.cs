using NUnit.Framework;
using _03122018.Solution;

namespace Tests
{
    public class SolutionUnitTests
    {
        [Test]
        [TestCase(new int[] {1, 2, 3, 4, 5}, new int[] {120, 60, 40, 30, 24})]
        [TestCase(new int[] {3, 2, 1}, new int[] {2, 3, 6})]
        public void Test1(int[] inputNumbers, int[] expectedOutput)
        {
            var result = Solution.Solve(inputNumbers);
            
            Assert.AreEqual(result, expectedOutput);
        }
    }
}