using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap he so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap he so b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap he so c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap he so x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap he so y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            double d = (a * x + b * y + c) / Math.Sqrt(a * a + b * b);
            Console.WriteLine($"Khoang cach tu 1 diem den duong thang la: {d}");
        }
    }
}
