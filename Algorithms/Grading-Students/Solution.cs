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
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents (List<int> grades) {
        var result = new List<int> ();
        foreach (var grade in grades) {
            if (grade >= 38) {
                if (grade % 5 == 4) {
                    result.Add (grade + 1);
                } else if (grade % 5 == 3) {
                    result.Add (grade + 2);
                } else {
                    result.Add (grade);
                }
            } else {
                result.Add (grade);
            }
        }
        return result;
    }

}

class Solution {
    public static void Main (string[] args) {
        TextWriter textWriter = new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32 (Console.ReadLine ().Trim ());

        List<int> grades = new List<int> ();

        for (int i = 0; i < gradesCount; i++) {
            int gradesItem = Convert.ToInt32 (Console.ReadLine ().Trim ());
            grades.Add (gradesItem);
        }

        List<int> result = Result.gradingStudents (grades);

        textWriter.WriteLine (String.Join ("\n", result));

        textWriter.Flush ();
        textWriter.Close ();
    }
}
