using System;
using System.Collections.Generic;

namespace b25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> T = new List<int>() { 1, 4, 7, 8, 9, 6, 3, 2, 5 };
            int gtln = T[0];
            int gtnn = T[0];
            foreach (int num in T) 
            { 
                if(num > gtln)
                {
                    gtln = num;
                }
                if (num < gtnn) 
                { 
                    gtnn = num;
                }
            }
            Console.WriteLine($"GTLN: {gtln}, GTNN: {gtnn}");
        }
    }
}
