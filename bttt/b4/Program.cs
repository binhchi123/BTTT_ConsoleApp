using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap gio: ");
            int gio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap phut: ");
            int phut = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap giay: ");
            int giay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap quang duong: ");
            double s = Convert.ToDouble(Console.ReadLine());
            double tonggio = gio + phut / 60 + giay / 3600;
            double vkmh = s / tonggio;
            double vms = vkmh / 3.6;
            double vmh = vkmh*1000;
            Console.WriteLine($"Van toc theo km/h: {vkmh} km/h");
            Console.WriteLine($"Van toc theo m/h: {vmh} m/h");
            Console.WriteLine($"Van toc theo m/s: {vms} m/s");
        }
    }
}
