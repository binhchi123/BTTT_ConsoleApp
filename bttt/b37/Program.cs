using System;

namespace b37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());                       
            bool hasPrime = false;
            Console.WriteLine("Cac so nguyen to nho hon n la: ");         
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                    hasPrime = true;
                }
            }
            if (!hasPrime)
            {
                Console.Write("Khong co so nguyen to nao nho hon n");               
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
