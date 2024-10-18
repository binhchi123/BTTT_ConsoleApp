using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so 2-8: ");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 2:
                    Console.WriteLine("Thu hai");
                    break;
                case 3:
                    Console.WriteLine("Thu ba");
                    break;
                case 4:
                    Console.WriteLine("Thu tu");
                    break;
                case 5:
                    Console.WriteLine("Thu nam");
                    break;
                case 6:
                    Console.WriteLine("Thu sau");
                    break;
                case 7:
                    Console.WriteLine("Thu bay");
                    break;
                case 8:
                    Console.WriteLine("Thu chu nhat");
                    break;
                default:
                    Console.WriteLine("Khong phai thu trong tuan");
                    break;
            }
        }
    }
}
