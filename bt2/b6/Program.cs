using System;

namespace b6
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
            Console.Write("Nhap so nguyen can tim: ");
            int search = Convert.ToInt32(Console.ReadLine());           
            Array.Sort(arr);
            int index = Array.IndexOf(arr, search);
            Console.WriteLine($"Mang da sap xep: [{string.Join(", ", arr)}]");
            if (index != -1)
            {
                Console.WriteLine($"Vi tri dau tien xuat hien cua so do: {index}");
            }
            else {
                Console.WriteLine("Khong tim thay vi tri dau tien xuat hien cua so do");
            }
        }
    }
}
