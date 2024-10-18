using System;

namespace b35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Nhap cac phan tu cua mang");
            for (int i = 0; i < n; i++) {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int tich = 1;
            bool hasPrime = false;
            foreach (int number in arr) {
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
