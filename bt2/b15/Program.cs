using System;

namespace b15
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
            bool asc = true;
            bool desc = true;
            for (int i = 0; i < n-1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    asc = false;
                }
                else if (arr[i] < arr[i + 1])
                {
                    desc = false;
                }
            }
            Console.WriteLine($"Mang: [{string.Join(", ", arr)}]");
            if (asc)
            {
                Console.WriteLine("Mang tang dan");
            }
            else if (desc)
            {
                Console.WriteLine("Mang giam dan");
            }
            else
            {
                Console.WriteLine("Mang hon don");
            }
        }
    }
}
