using BeFaster.App.Solutions.HLO;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.HLO
{
    [TestFixture]
    public class HelloSolutionTest
    {
        [TestCase("John", ExpectedResult = "Hello, John!")] // Valid name
        [TestCase("Anne", ExpectedResult = "Hello, Anne!")] // Another valid name
        public string Hello_ValidInputs_ReturnsGreeting(string friendName)
        {
            return HelloSolution.Hello(friendName);
        }

        [TestCase("")] // Empty string
        [TestCase(" ")] // Whitespace
        public void Hello_InvalidInputs_ThrowsException(string friendName)
        {
            Assert.Throws<ArgumentException>(() => HelloSolution.Hello(friendName));
        }
    }
}




