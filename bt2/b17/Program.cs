using System;
using System.Collections.Generic;

namespace b17
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
            List<int> prime = new List<int>();
            int tich = 1;
            bool hasPrime = false;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    le.Add(arr[i]);
                    if (IsPrime(arr[i]))   
                    {
                        prime.Add(arr[i]);
                        if (i % 2 == 0) 
                        { 
                            tich*= arr[i];
                            hasPrime = true;
                        }
                    }
                }
            }
            Console.WriteLine($"Mang vu nhap: [{string.Join(", ", arr)}]");
            Console.WriteLine($"Cac phan tu le: [{string.Join(", ", le)}]");
            Console.WriteLine($"Cac phan tu le la so nguyen to: [{string.Join(", ", prime)}]");
            if (hasPrime)
            {
                Console.WriteLine($"Tich cac so nguyen to o vi tri chan la: {tich}");
            }
            else
            {
                Console.WriteLine("Mang vua nhap vao khong ton tai so nguyen nao");
            }
        }
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
