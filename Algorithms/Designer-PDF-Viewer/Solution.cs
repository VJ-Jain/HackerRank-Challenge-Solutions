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

    static int getHeight (int[] h, char s) {
        switch (s) {
            case 'a':
                return h[0];
            case 'b':
                return h[1];
            case 'c':
                return h[2];
            case 'd':
                return h[3];
            case 'e':
                return h[4];
            case 'f':
                return h[5];
            case 'g':
                return h[6];
            case 'h':
                return h[7];
            case 'i':
                return h[8];
            case 'j':
                return h[9];
            case 'k':
                return h[10];
            case 'l':
                return h[11];
            case 'm':
                return h[12];
            case 'n':
                return h[13];
            case 'o':
                return h[14];
            case 'p':
                return h[15];
            case 'q':
                return h[16];
            case 'r':
                return h[17];
            case 's':
                return h[18];
            case 't':
                return h[19];
            case 'u':
                return h[20];
            case 'v':
                return h[21];
            case 'w':
                return h[22];
            case 'x':
                return h[23];
            case 'y':
                return h[24];
            case 'z':
                return h[25];
        }
        return 0;
    }

    static int designerPdfViewer (int[] h, string word) {
        var maxheight = 0;
        for (var position = 0; position < word.Length; position++) {
            var letterHeight = getHeight (h, word[position]);
            if (letterHeight > maxheight)
                maxheight = letterHeight;
        }

        return maxheight * word.Length;
    }

    static void Main (string[] args) {
        TextWriter textWriter = new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);

        int[] h = Array.ConvertAll (Console.ReadLine ().Split (' '), hTemp => Convert.ToInt32 (hTemp));
        string word = Console.ReadLine ();

        int result = designerPdfViewer (h, word);

        textWriter.WriteLine (result);

        textWriter.Flush ();
        textWriter.Close ();
    }
}
