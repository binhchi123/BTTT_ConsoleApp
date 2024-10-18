using System;
using System.Diagnostics.CodeAnalysis;

namespace b31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen a: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int a))
            {
                int sum = SumOfDigits(a);
                Console.WriteLine($"Tong cac chu so cua a {a} la: {sum}");
                if (sum % 3 == 0)
                {
                    Console.WriteLine($"{a} chia het cho 3.");
                }
                else
                {
                    Console.WriteLine($"{a} khong chia het cho 3.");
                }
            }
            else
            {
                Console.WriteLine("Hay nhap mot so nguyen.");
            }
        }

        static int SumOfDigits(int number)
        {
            int sum = 0;
            number = Math.Abs(number); 

            while (number > 0)
            {
                sum += number % 10; 
                number /= 10; 
            }

            return sum;
        }
    }
}
