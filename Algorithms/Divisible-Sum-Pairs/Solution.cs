using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;

class Solution {

    // Complete the divisibleSumPairs function below.
    static int divisibleSumPairs (int n, int k, int[] ar) {
        var validPairs = 0;
        for (var i = 0; i < n; i++) {
            for (var j = i + 1; j < n; j++) {
                if ((ar[i] + ar[j]) % k == 0) {
                    validPairs += 1;
                }
            }
        }
        return validPairs;
    }

    static void Main (string[] args) {
        TextWriter textWriter = new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine ().Split (' ');

        int n = Convert.ToInt32 (nk[0]);
        int k = Convert.ToInt32 (nk[1]);

        int[] ar = Array.ConvertAll (Console.ReadLine ().Split (' '), arTemp => Convert.ToInt32 (arTemp));
        int result = divisibleSumPairs (n, k, ar);

        textWriter.WriteLine (result);

        textWriter.Flush ();
        textWriter.Close ();
    }
}
