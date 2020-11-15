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

    // Complete the saveThePrisoner function below.
    static int saveThePrisoner (int n, int m, int s) {
        m = m % n;
        var sweetsDistributed = 0;
        var currentPrisoner = s - 1;
        if (currentPrisoner == 0)
            currentPrisoner = n;
        currentPrisoner += m;
        if (currentPrisoner > n)
            currentPrisoner = currentPrisoner - n;
        return currentPrisoner;
    }

    static void Main (string[] args) {
        TextWriter textWriter = new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);
        int t = Convert.ToInt32 (Console.ReadLine ());

        for (int tItr = 0; tItr < t; tItr++) {
            string[] nms = Console.ReadLine ().Split (' ');
            int n = Convert.ToInt32 (nms[0]);
            int m = Convert.ToInt32 (nms[1]);
            int s = Convert.ToInt32 (nms[2]);
            int result = saveThePrisoner (n, m, s);
            textWriter.WriteLine (result);
        }

        textWriter.Flush ();
        textWriter.Close ();
    }
}
