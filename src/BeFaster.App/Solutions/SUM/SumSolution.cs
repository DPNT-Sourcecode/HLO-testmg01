﻿using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.SUM
{
    public static class SumSolution
    {
        public static int Sum(int x, int y)
        {
            // Ensure inputs are within the range of 0 to 100
            if (x < 0 || x > 100 || y < 0 || y > 100)
            {
                throw new ArgumentOutOfRangeException("Inputs must be between 0 and 100");
            }

            // return the sum of x & y
            return x + y;
        }
    }
}
