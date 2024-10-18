using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so thu hai b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so thu ba c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so thu tu d: ");
            double d = Convert.ToDouble(Console.ReadLine());
            double avg = (a + b + c + d) / 4;
            double roundedAvg = Math.Round(avg, 3);
            Console.Write($"Trung binh cong cua 4 so la: {roundedAvg}");
        }
    }
}
