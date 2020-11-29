using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the dayOfProgrammer function below.
    static string dayOfProgrammer(int year) {
        var isLeap = false;
        if(year <= 1917)
        {
            isLeap = isYearJulianLeap(year);
        }
        else if(year >= 1919)
        {
            isLeap = isYearGregorianLeap(year);
        }
        else if(year == 1918)
           return "26.09.1918"; 
        if(isLeap)
            return $"12.09.{year}";
        else
            return $"13.09.{year}";
    }
    
    static bool isYearJulianLeap(int year) {
        if(year%4 == 0)
            return true;
        return false;
    }
    
    static bool isYearGregorianLeap(int year) {
        if(year%400 == 0)
            return true;
        else if (year%4 == 0 && year%100 !=0)
            return true;
        return false;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = dayOfProgrammer(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
