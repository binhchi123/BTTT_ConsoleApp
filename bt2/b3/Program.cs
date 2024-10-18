using System;

namespace b3
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
            int tich = 1;
            bool hasPrime = false;
            foreach (int number in arr)
            {
                if (IsPrime(number))
                {
                    tich *= number;
                    hasPrime = true;
                }
            }
            if (hasPrime)
            {
                Console.WriteLine($"Tich cac so nguyen trong mang vua nhap la: {tich}");
            }
            else
            {
                Console.WriteLine("Mang vua nhap vao khong ton tai so nguyen nao");
            }
        }
        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
