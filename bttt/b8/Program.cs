using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ban kin r: ");
            int r = Convert.ToInt32(Console.ReadLine());
            double c = 2 * Math.PI * r;
            double s = Math.Pow(c, 2) / 4 * Math.PI;
            Console.WriteLine($"Chu vi hinh tron: {c}, Dien tich hinh tron: {s}");
        }
    }
}
