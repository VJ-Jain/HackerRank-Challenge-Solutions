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

    // Complete the migratoryBirds function below.
    static int migratoryBirds (List<int> arr) {
        var birdSightings = new Dictionary<int, int> ();
        foreach (var item in arr) {
            if (birdSightings.ContainsKey (item)) {
                birdSightings.TryGetValue (item, out int value);
                birdSightings[item] = value + 1;
            } else {
                birdSightings.Add (item, 1);
            }
        }

        var orderedBirdSightings = birdSightings.OrderByDescending(i => i.Value);
        var sightingsForMostSightedBird = orderedBirdSightings.First().Value;
        var mostSightedBirds = orderedBirdSightings.Where(i => i.Value == sightingsForMostSightedBird);

        return mostSightedBirds.OrderBy(i => i.Key).First().Key;
    }

    static void Main (string[] args) {
        TextWriter textWriter = new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32 (Console.ReadLine ().Trim ());

        List<int> arr = Console.ReadLine ().TrimEnd ().Split (' ').ToList ().Select (arrTemp => Convert.ToInt32 (arrTemp)).ToList ();

        int result = migratoryBirds (arr);

        textWriter.WriteLine (result);

        textWriter.Flush ();
        textWriter.Close ();
    }
}
