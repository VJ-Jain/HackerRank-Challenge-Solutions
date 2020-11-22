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

class Result
{

    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        var maxA = a.First();
        foreach(var aa in a)
        {
            if (aa>maxA)
                maxA = aa;
        }
        var minB = b.First();
        foreach(var bb in b)
        {
            if (bb<minB)
                minB = bb;
        }
        var rightNumbers = 0;
        for(var i = maxA; i<=minB; i++)
        {
            var rightNumber = true;
            foreach(var aa in a)
            {
               if(i%aa != 0)
               {
                   rightNumber = false;
                   break;
               }
            }
            if(rightNumber)
            {
                foreach(var bb in b)
                {
                    if(bb%i != 0)
                    {
                        rightNumber = false;
                        break;
                    }
                }
                if(rightNumber)
                    rightNumbers += 1;
            }            
        }
        return rightNumbers;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        textWriter.WriteLine(total);

        textWriter.Flush();
        textWriter.Close();
    }
}
