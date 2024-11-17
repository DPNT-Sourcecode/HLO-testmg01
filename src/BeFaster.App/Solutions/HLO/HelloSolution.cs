using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.HLO
{
    public static class HelloSolution
    {
        public static string Hello(string? friendName)
        {
            return string.IsNullOrWhiteSpace(friendName)
                ? "Hello, World"
                : $"Hello, {friendName}";
        }
    }
}
