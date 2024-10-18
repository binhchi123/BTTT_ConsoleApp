using System;
using System.Collections.Generic;

namespace b31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (IsIncreasing(n))
            {
                Console.WriteLine($"{n} la so tang");
            }
            else
            {
                Console.WriteLine($"{n} khong la so tang");
            }
        }
        static bool IsIncreasing(int number)
        {
            int lastDigit = 10; 
            while (number > 0)
            {
                int currentDigit = number % 10; 
                if (currentDigit > lastDigit)
                {
                    return false; 
                }
                lastDigit = currentDigit;
                number /= 10;
            }
            return true; 
        }
    }
}
