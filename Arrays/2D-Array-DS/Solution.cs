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

    static int hourglassSum (int[][] arr) {
        var sumTopRow = 0;
        var middleRowValue = 0;
        var sumBottomRow = 0;
        var sumHourGlass = 0;
        var result = 0;
        for (int row = 0; row <= 3; row++) {
            for (int column = 0; column <= 3; column++) {
                sumTopRow = arr[row][column] + arr[row][column + 1] + arr[row][column + 2];
                middleRowValue = arr[row + 1][column + 1];
                sumBottomRow = arr[row + 2][column] + arr[row + 2][column + 1] + arr[row + 2][column + 2];

                sumHourGlass = sumTopRow + middleRowValue + sumBottomRow;
                if (row == 0 && column == 0) {
                    result = sumHourGlass;
                }
                if (sumHourGlass > result) {
                    result = sumHourGlass;
                }
            }
        }
        return result;
    }

    static void Main (string[] args) {
        TextWriter textWriter = new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll (Console.ReadLine ().Split (' '), arrTemp => Convert.ToInt32 (arrTemp));
        }

        int result = hourglassSum (arr);
        textWriter.WriteLine (result);
        textWriter.Flush ();
        textWriter.Close ();
    }
}
