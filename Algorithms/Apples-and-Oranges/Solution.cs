using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the countApplesAndOranges function below.
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
        var applesInHouse = 0;
        var orangesInHouse = 0;
        for(var i = 0; i < apples.Length; i++)
        {
            if(apples[i] >= 0)
            {
                var fallLocation = apples[i] + a;
                if(fallLocation >= s && fallLocation <= t)
                    applesInHouse += 1;
            }
        }
        for(var i = 0; i < oranges.Length; i++)
        {
            if(oranges[i] <= 0)
            {
                var fallLocation = oranges[i] + b;
                if(fallLocation >= s && fallLocation <= t)
                    orangesInHouse += 1;
            }
        }
        Console.WriteLine(applesInHouse);
        Console.WriteLine(orangesInHouse);
    }

    static void Main(string[] args) {
        string[] st = Console.ReadLine().Split(' ');

        int s = Convert.ToInt32(st[0]);
        int t = Convert.ToInt32(st[1]);
        string[] ab = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(ab[0]);
        int b = Convert.ToInt32(ab[1]);
        string[] mn = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(mn[0]);
        int n = Convert.ToInt32(mn[1]);

        int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));

        int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));
        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
