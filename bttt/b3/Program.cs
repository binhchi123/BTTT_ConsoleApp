using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao ban kinh hinh cau: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double s = 4 * Math.PI * Math.Pow(r, 2);
            double p = 2 * Math.PI * r;
            Console.WriteLine($"Dien tich cua hinh cau la: {s}. Chu vi hinh cau la: {p}");
        }
    }
}
