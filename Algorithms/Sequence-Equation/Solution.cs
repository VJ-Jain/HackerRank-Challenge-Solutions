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

    // Complete the permutationEquation function below.
    static int[] permutationEquation (int[] p) {
        var result = new int[p.Length];
        for (var i = 0; i < p.Length; i++) {
            var x = i + 1;
            for (var j = 0; j < p.Length; j++) {
                if (x == p[j]) {
                    var x2 = j + 1;
                    for (var k = 0; k < p.Length; k++) {
                        if (x2 == p[k]) {
                            result[i] = k + 1;
                        }
                    }
                }
            }
        }
        return result;
    }

    static void Main (string[] args) {
        TextWriter textWriter = new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);

        int n = Convert.ToInt32 (Console.ReadLine ());

        int[] p = Array.ConvertAll (Console.ReadLine ().Split (' '), pTemp => Convert.ToInt32 (pTemp));
        int[] result = permutationEquation (p);

        textWriter.WriteLine (string.Join ("\n", result));

        textWriter.Flush ();
        textWriter.Close ();
    }
}
