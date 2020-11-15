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

    // Complete the viralAdvertising function below.
    static int viralAdvertising (int n) {
        var sharedWith = 5;
        var likedTotal = 0;
        for (var day = 1; day <= n; day++) {
            var likedToday = (sharedWith / 2);
            likedTotal += likedToday;
            sharedWith = likedToday * 3;
        }

        return likedTotal;
    }

    static void Main (string[] args) {
        TextWriter textWriter = new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);

        int n = Convert.ToInt32 (Console.ReadLine ());
        int result = viralAdvertising (n);
        textWriter.WriteLine (result);

        textWriter.Flush ();
        textWriter.Close ();
    }
}