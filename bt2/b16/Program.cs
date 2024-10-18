using System;

namespace b16
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
            bool doiXung = true;
            for (int i = 0; i < n / 2; i++) {
                if (arr[i] != arr[n - 1 - i])
                {
                    doiXung = false;
                    break;
                }
            }
            Console.WriteLine($"Mang: [{string.Join(", ", arr)}]");
            if (doiXung)
            {
                Console.WriteLine("La mang doi xung");
            }
            else {
                Console.WriteLine("Khong la mang doi xung");
            }
        }
    }
}
