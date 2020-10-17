using System.Collections.Generic;
using System;

namespace Sales_by_Match
{
    class Program
    {
        static int SockMerchant(int n, int[] ar)
        {
            var dict = new Dictionary<int, int>();
            foreach(var item in ar)
            {
                if(dict.ContainsKey(item))
                {
                    dict[item] = dict[item] + 1;
                } else
                {
                    dict.Add(item, 1);
                }
            }
            var result = 0;
            foreach (var item in dict)
            {
                result += item.Value / 2;
            }
            return result;
        }

        static void TestSockMerchant(int n, int[] ar, int expectedResult)
        {
            if (SockMerchant(n, ar) == expectedResult)
                Console.WriteLine($"Sock Merchant is VALID for INPUT  = {n}, {string.Join(' ', ar)}");
            else
                Console.WriteLine($"Sock Merchant is INVALID for INPUT  = {n}, {string.Join(' ', ar)}");
        }

        static void Main(string[] args)
        {
            TestSockMerchant(3, new int[] { 1, 2, 1 }, 1);
            TestSockMerchant(4, new int[] { 1, 2, 1, 2 }, 2);
            TestSockMerchant(9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, 3);
            TestSockMerchant(10, new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 }, 4);
        }
    }
}
