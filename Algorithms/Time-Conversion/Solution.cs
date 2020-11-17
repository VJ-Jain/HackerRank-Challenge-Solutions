using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion (string s) {
        /*
         * Write your code here.
         */
        var strparts = s.Split (':');
        var hrs = int.Parse (strparts[0]);
        var mins = strparts[1];
        var secs = strparts[2].Replace ("PM", "");
        secs = secs.Replace ("AM", "");

        var hrsS = "";
        if (strparts[2].Contains ("PM")) {
            if (hrs != 12)
                hrs = hrs + 12;
            hrsS = hrs.ToString ();
        } else if (hrs == 12) {
            hrsS = "00";
        } else {
            hrsS = strparts[0];
        }
        return $"{hrsS}:{mins}:{secs}";
    }

    static void Main (string[] args) {
        TextWriter tw = new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);

        string s = Console.ReadLine ();

        string result = timeConversion (s);

        tw.WriteLine (result);

        tw.Flush ();
        tw.Close ();
    }
}
