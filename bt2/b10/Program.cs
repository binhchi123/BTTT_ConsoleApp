using System;

namespace b10
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
            int min = arr[0];
            int max = arr[0];
            foreach (int num in arr) 
            { 
                if(num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }
            int total = (min * min) + (max * max);
            Console.WriteLine($"So nho nhat trong mang: {min}");
            Console.WriteLine($"So lon nhat trong mang: {max}");
            Console.WriteLine($"Tong binh phuong cua min va max trong mang: {total}");
        }
    }
}
