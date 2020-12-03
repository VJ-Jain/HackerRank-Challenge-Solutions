using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the pageCount function below.
     */
    static int pageCount(int n, int p) {
        var totalPagesAvailableToTurn = n/2;
        var pagesToTurnFromFront = p/2;
        var pagesToTurnFromBack = totalPagesAvailableToTurn - pagesToTurnFromFront;

        if (pagesToTurnFromFront <= pagesToTurnFromBack)
            return pagesToTurnFromFront;
        else
            return pagesToTurnFromBack;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int p = Convert.ToInt32(Console.ReadLine());

        int result = pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
