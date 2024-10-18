using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen tu 1-12: ");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Mua xuan");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Mua he");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Mua thu");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Mua dong");
                    break;
            }
        }
    }
}
