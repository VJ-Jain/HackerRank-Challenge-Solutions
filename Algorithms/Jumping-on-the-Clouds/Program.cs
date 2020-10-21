using System;

namespace Jumping_on_the_Clouds
{
    class Program
    {
        static int JumpingOnClouds(int[] c)
        {
            int jumps = 0;
            int currentPos = 0;
            int lastPos = c.Length - 1;

            // first & last cloud will always be safe.
            while (currentPos < lastPos)
            {
                if (currentPos+2 <= lastPos && c[currentPos + 2] == 0)
                    currentPos += 2;
                else
                    currentPos += 1;
                jumps += 1;
            }
            return jumps;
        }

        static void TestJumpingOnClouds(int[] c, int expectedResult)
        {
            if (JumpingOnClouds(c) == expectedResult)
                Console.WriteLine($"Jumping On Clouds is VALID for INPUT {string.Join(' ', c)}");
            else
                Console.WriteLine($"Jumping On Clouds is INVALID for INPUT {string.Join(' ', c)}");
        }

        static void Main(string[] args)
        {
            TestJumpingOnClouds(new int[] { 0, 0, 1, 0, 0, 1, 0 }, 4);
            TestJumpingOnClouds(new int[] { 0, 0, 0, 1, 0, 0 }, 3);
        }
    }
}
