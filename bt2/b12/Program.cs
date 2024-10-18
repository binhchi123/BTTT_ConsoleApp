using System;

namespace b12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[n];
            Console.WriteLine("Nhap cac phan tu mang:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Phan tu {i + 1}: ");
                arr[i] = (Console.ReadLine());
            }
            Array.Sort(arr, (s1, s2) => s2.Length.CompareTo(s1.Length));
            Console.WriteLine($"Mang da sap xep: [{string.Join(", ", arr)}]");
        }
    }
}
