using System;
using System.Collections.Generic;

namespace b27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> cu = new List<double>() { 2, 4, 5, 6, 7, 8};
            List<double> moi = new List<double>();
            int count = 0;
            foreach (double i in cu) 
            { 
                double pow = Math.Pow(i, 2);
                moi.Add(pow);
            }
            foreach (double i in moi)
            {
                Console.Write(i + " ");
                if (i > 20) count++;
            }
            Console.WriteLine("");
            Console.WriteLine($"Danh sach moi co {count} lon hon 20");
        }
    }
}
