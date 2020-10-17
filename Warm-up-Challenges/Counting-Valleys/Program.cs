using System;

namespace Counting_Valleys
{
    class Program
    {
        public static int CountingValleys(int steps, string path)
        {
            var currentLevel = 0;
            var existingValley = false;
            int valleys = 0;
            for (int pos = 0; pos < steps; pos++)
            {
                if (currentLevel < 0)
                    existingValley = true;
                if (path[pos] == 'U')
                    currentLevel += 1;
                else if (path[pos] == 'D')
                    currentLevel -= 1;
                if (currentLevel < 0 && !existingValley)
                    valleys += 1;
                if (currentLevel == 0)
                    existingValley = false;
            }
            return valleys;
        }

        public static void TestCountingValleys(int steps, string path, int expectedResult)
        {
            if (CountingValleys(steps, path) == expectedResult)
                Console.WriteLine($"Counting Valleys is VALID for INPUT {steps}, {path}");
            else
                Console.WriteLine($"Counting Valleys is INVALID for INPUT {steps}, {path}");
        }

        public static void Main(string[] args)
        {
            TestCountingValleys(8, "UDDDUDUU", 1);
            TestCountingValleys(12, "DDUUDDUDUUUD", 2);
        }
    }
}
