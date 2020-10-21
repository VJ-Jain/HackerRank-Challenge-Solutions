using System;
using System.Linq;

namespace Repeated_String
{
    class Program
    {
        static long RepeatedString(string s, long n)
        {
            var numberOfAInPattern = s.Where(_ => _ == 'a').Count();

            var noOfTimesPatternCanOccurFully = n/s.Length;
            var noOfCharsLeftToIncludeFromPattern = n%s.Length;

            var leftOverPattern = s.Substring(0, Convert.ToInt32(noOfCharsLeftToIncludeFromPattern));
            var numberOfAInleftOverPattern = leftOverPattern.Where(_ => _ == 'a').Count();

            return (numberOfAInPattern * noOfTimesPatternCanOccurFully) + numberOfAInleftOverPattern;
        }

        static void TestRepeatedString(string s, long n, long expectedResult)
        {
            if (RepeatedString(s, n) == expectedResult)
                Console.WriteLine($"Repeated String is VALID for INPUT {s}, {n}");
            else
                Console.WriteLine($"Repeated String is INVALID for INPUT {s}, {n}");
        }

        static void Main(string[] args)
        {
            TestRepeatedString("aba", 10, 7);
            TestRepeatedString("a", 1000000000000, 1000000000000);
        }
    }
}
