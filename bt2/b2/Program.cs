using System;
using System.Diagnostics.CodeAnalysis;

namespace b2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[n];
            Console.WriteLine("Nhap cac phan tu mang:");
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine($"Phan tu {i + 1}");
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }
            double sum = 0;
            foreach (double num in arr) {
                sum += num;
            }
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
            Console.WriteLine($"Tong tat ca trong phan tu mang: {sum}");
        }
    }
}
