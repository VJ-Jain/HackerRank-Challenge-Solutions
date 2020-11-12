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

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds (int[] c, int k) {
        var currentCloud = 0;
        var energyLeft = 100;
        do {
            currentCloud += k;
            if (currentCloud >= c.Length)
                currentCloud = currentCloud - c.Length;
            energyLeft -= 1;
            if (c[currentCloud] == 1)
                energyLeft -= 2;
        }
        while (currentCloud != 0);
        return energyLeft;
    }

    static void Main (string[] args) {
        TextWriter textWriter = new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine ().Split (' ');

        int n = Convert.ToInt32 (nk[0]);

        int k = Convert.ToInt32 (nk[1]);

        int[] c = Array.ConvertAll (Console.ReadLine ().Split (' '), cTemp => Convert.ToInt32 (cTemp));
        int result = jumpingOnClouds (c, k);

        textWriter.WriteLine (result);

        textWriter.Flush ();
        textWriter.Close ();
    }
}
