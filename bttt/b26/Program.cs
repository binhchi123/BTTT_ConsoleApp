using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số nguyên dương a: ");
            int a = Convert.ToInt32(Console.ReadLine());
           
            for (int i = a; i > 0; i--)
            {
                if (a % i == 0 && i % 2 != 0) // Kiểm tra ước số lẻ
                {
                    Console.WriteLine(i); // In ước số lẻ
                    break;
                }
            }
        }
    }
}
