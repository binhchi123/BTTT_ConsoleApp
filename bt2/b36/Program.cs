using System;

namespace b36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool soChinhPhuong = Check(n);
            if (soChinhPhuong) {
                Console.WriteLine($"{n} la so chinh phuong");
            }
            else
            {
                Console.WriteLine($"{n} khong la so chinh phuong");
            }
        }
        static bool Check(int n)
        {
            if (n < 0)
            {
                return false;
            }
            int sqrt = (int)Math.Sqrt(n);
            return sqrt * sqrt == n;
        }
    }
}
