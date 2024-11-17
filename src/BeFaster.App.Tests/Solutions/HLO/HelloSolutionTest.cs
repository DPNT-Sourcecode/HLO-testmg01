using BeFaster.App.Solutions.HLO;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.HLO
{
    [TestFixture]
    public class HelloSolutionTest
    {
        [TestCase("", ExpectedResult = "Hello, World")] // Empty string
        [TestCase(" ", ExpectedResult = "Hello, World")] // White space
        [TestCase("John", ExpectedResult = "Hello, John")] // Valid name
        [TestCase("Anne", ExpectedResult = "Hello, Anne")] // Another valid name
        public string Hello_ReturnCorrectGreeting(string friendName)
        {
            return HelloSolution.Hello(friendName);
        }
    }
}

