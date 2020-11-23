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

    // Complete the breakingRecords function below.
    static int[] breakingRecords (int[] scores) {
        var minScore = scores[0];
        var maxScore = scores[0];
        var minRecordBroken = 0;
        var maxRecordBroken = 0;
        foreach (var score in scores) {
            if (score > maxScore) {
                maxScore = score;
                maxRecordBroken += 1;
            } else if (score < minScore) {
                minScore = score;
                minRecordBroken += 1;
            }
        }
        int[] result = { maxRecordBroken, minRecordBroken };

        return result;
    }

    static void Main (string[] args) {
        TextWriter textWriter = new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);

        int n = Convert.ToInt32 (Console.ReadLine ());

        int[] scores = Array.ConvertAll (Console.ReadLine ().Split (' '), scoresTemp => Convert.ToInt32 (scoresTemp));
        int[] result = breakingRecords (scores);

        textWriter.WriteLine (string.Join (" ", result));

        textWriter.Flush ();
        textWriter.Close ();
    }
}
