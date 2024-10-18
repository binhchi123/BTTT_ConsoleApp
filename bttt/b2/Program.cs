using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao do C: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double k = c + 273.15;
            double f = (c * 1.8) + 32;
            Console.WriteLine($"{c} do C la {k} do K va {f} do F");
        }
    }
}
