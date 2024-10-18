using System;
using System.Collections.Generic;

namespace b35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Input(arr, n);
            Print(arr);
        }
        static void Input(int[] arr, int n)
        {
            Console.WriteLine("Nhap cac phan tu cua mang");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phan tu {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Print(int[] arr)
        {
            Console.WriteLine($"Mang vua nhap la: {string.Join(", ", arr)}");
        }
    }
}
