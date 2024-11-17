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
    }
}

