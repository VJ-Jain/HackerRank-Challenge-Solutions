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
    static int equalizeArray (int[] arr) {
        var frequency = new Dictionary<int, int> ();
        for (var pos = 0; pos < arr.Length; pos++) {
            if (frequency.ContainsKey (arr[pos]))
                frequency[arr[pos]] = frequency[arr[pos]] + 1;
            else
                frequency.Add (arr[pos], 1);
        }
        var maximumOccurence = 0;
        foreach (var item in frequency.Values) {
            if (item > maximumOccurence)
                maximumOccurence = item;
        }
        return arr.Length - maximumOccurence;
    }

    static void Main (string[] args) {
        TextWriter textWriter = new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);

        int n = Convert.ToInt32 (Console.ReadLine ());

        int[] arr = Array.ConvertAll (Console.ReadLine ().Split (' '), arrTemp => Convert.ToInt32 (arrTemp));
        int result = equalizeArray (arr);

        textWriter.WriteLine (result);

        textWriter.Flush ();
        textWriter.Close ();
    }
}
