using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số nguyên dương a (a < 100): ");
            int a = Convert.ToInt32(Console.ReadLine());

            // Kiểm tra điều kiện a < 100
            if (a < 100 && a > 0)
            {
                int sumEvenDivisors = 0;

                // Tìm và tính tổng các ước số chẵn của a
                for (int i = 1; i <= a; i++)
                {
                    if (a % i == 0 && i % 2 == 0) // Kiểm tra ước số chẵn
                    {
                        sumEvenDivisors += i;
                    }
                }

                // In kết quả
                Console.WriteLine($"Tổng các ước số chẵn của {a} là {sumEvenDivisors}.");
            }
            else
            {
                Console.WriteLine("Vui lòng nhập số nguyên dương a < 100.");
            }
        }
    }
}
