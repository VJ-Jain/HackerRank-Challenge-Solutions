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

class Result {

    /*
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */

    public static int birthdayCakeCandles (List<int> candles) {
        var tallest = candles.First ();
        var count = 0;
        foreach (var candle in candles) {
            if (candle > tallest)
                tallest = candle;
        }
        foreach (var candle in candles) {
            if (candle == tallest)
                count += 1;
        }

        return count;
    }

}

class Solution {
    public static void Main (string[] args) {
        TextWriter textWriter = new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);

        int candlesCount = Convert.ToInt32 (Console.ReadLine ().Trim ());

        List<int> candles = Console.ReadLine ().TrimEnd ().Split (' ').ToList ().Select (candlesTemp => Convert.ToInt32 (candlesTemp)).ToList ();

        int result = Result.birthdayCakeCandles (candles);

        textWriter.WriteLine (result);

        textWriter.Flush ();
        textWriter.Close ();
    }
}
