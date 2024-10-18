using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap a1: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap a2: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap b1: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap b2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            if (a1 != 0 && a2 != 0)
            {
                if (a1 == a2)
                {
                    if (b1 == b2)
                    {
                        Console.WriteLine("Hai duong thang trung nhau");
                    }
                    else
                    {
                        Console.WriteLine("Hai duong thang song song");
                    }
                }
                else
                {
                    if(a1*a2 == -1)
                    {
                        Console.WriteLine("Hai duong thang vuong goc");
                    }
                    else
                    {
                        Console.WriteLine("Hai duong thang cat nhau");
                    }
                }
            }
            else
            {
                Console.WriteLine("a1, a2 phai khac 0");
            }
        }
    }
}
