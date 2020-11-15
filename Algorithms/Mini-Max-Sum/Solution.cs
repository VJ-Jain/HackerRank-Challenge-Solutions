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

    // Complete the miniMaxSum function below.
    static void miniMaxSum (int[] arr) {
        var minimum = arr[0];
        var maximum = arr[0];
        long sum = 0;
        for (var i = 0; i < arr.Length; i++) {
            sum += arr[i];
            if (arr[i] < minimum)
                minimum = arr[i];
            if (arr[i] > maximum)
                maximum = arr[i];
        }
        Console.Write (sum - maximum);
        Console.Write (" ");
        Console.Write (sum - minimum);
    }

    static void Main (string[] args) {
        int[] arr = Array.ConvertAll (Console.ReadLine ().Split (' '), arrTemp => Convert.ToInt32 (arrTemp));
        miniMaxSum (arr);
    }
}
