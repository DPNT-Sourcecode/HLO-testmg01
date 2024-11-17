using BeFaster.App.Solutions.SUM;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.SUM
{
    [TestFixture]
    public class SumSolutionTest
    {
        [TestCase(1, 1, ExpectedResult = 2)]
        public int ComputeSum(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }

        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(100, 100, ExpectedResult = 200)]
        [TestCase(50, 50, ExpectedResult = 100)]
        [TestCase(10, 90, ExpectedResult = 100)]
        public int ComputeSum_ValidInputs(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }

        [TestCase(-1, 50)] // Negative input
        [TestCase(50, -1)] // Negative input
        [TestCase(101, 50)] // Input above 100
        [TestCase(50, 101)] // Input above 100
        public void ComputeSum_InvalidInputs(int x, int y)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => SumSolution.Sum(x, y));
        }
    }
}
