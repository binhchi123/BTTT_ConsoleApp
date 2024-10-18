using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so thu hai b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"So sau khi hoan vi: a = {a}, b = {b}");
        }
    }
}
