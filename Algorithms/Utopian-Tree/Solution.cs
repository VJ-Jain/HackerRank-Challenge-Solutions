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

    // Complete the utopianTree function below.
    static int utopianTree (int n) {
        var height = 1;
        for (var i = 1; i <= n; i++) {
            if (i % 2 == 0) {
                height += 1;
            } else {
                height = height * 2;
            }
        }
        return height;
    }

    static void Main (string[] args) {
        TextWriter textWriter = new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);

        int t = Convert.ToInt32 (Console.ReadLine ());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32 (Console.ReadLine ());

            int result = utopianTree (n);

            textWriter.WriteLine (result);
        }

        textWriter.Flush ();
        textWriter.Close ();
    }
}
