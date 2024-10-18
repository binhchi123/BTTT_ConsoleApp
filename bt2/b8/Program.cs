using System;
using System.Collections.Generic;

namespace b8
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
            List<int> le = new List<int>();
            foreach (int num in arr)
            {
                if(num % 2 != 0)
                {
                    le.Add(num);
                }
            }
            double totalLe = le.Count;
            double totalArr = arr.Length;
            double percen = (totalLe / totalArr) * 100;
            Console.WriteLine($"Cac phan tu le trong mang: {string.Join(", ", le)}");
            Console.WriteLine($"Ty le xuat hien cua cac phan tu le trong mang: {percen}%");
        }
    }
}
