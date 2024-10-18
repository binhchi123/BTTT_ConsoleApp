using System;
using System.Collections.Generic;

namespace b19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Nhap so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Nhap cac phan tu mang:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Phan tu {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            List<int> chan = new List<int>();
            List<int> le = new List<int>();
            foreach (int i in arr) 
            {
                if (i % 2 == 0)
                {
                    chan.Add(i);
                }
                else 
                { 
                    le.Add(i);
                }
            }
            int[] arrChan = chan.ToArray();
            int[] arrLe = le.ToArray();
            Console.WriteLine($"Mang chan: [{string.Join(", ", arrChan)}]");
            Console.WriteLine($"Mang le: [{string.Join(", ", arrLe)}]");
        }
    }
}
