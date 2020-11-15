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

    // Complete the beautifulDays function below.
    static int beautifulDays (int i, int j, int k) {
        var beautifulDay = 0;
        for (var day = i; day <= j; day++) {
            var difference = Math.Abs (day - getReverse (day));
            if (difference % k == 0)
                beautifulDay += 1;
        }
        return beautifulDay;
    }

    static int getReverse (int x) {
        var input = x.ToString ();
        char[] chars = input.ToCharArray ();
        for (int i = 0, j = input.Length - 1; i < j; i++, j--) {
            chars[i] = input[j];
            chars[j] = input[i];
        }
        return Convert.ToInt32 (new string (chars));
    }

    static void Main (string[] args) {
        TextWriter textWriter = new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);
        string[] ijk = Console.ReadLine ().Split (' ');
        int i = Convert.ToInt32 (ijk[0]);
        int j = Convert.ToInt32 (ijk[1]);
        int k = Convert.ToInt32 (ijk[2]);
        int result = beautifulDays (i, j, k);
        textWriter.WriteLine (result);
        textWriter.Flush ();
        textWriter.Close ();
    }
}
