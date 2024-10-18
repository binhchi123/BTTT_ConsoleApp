using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so nguyen b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("a lon hon b");
            }
            else
            {
                Console.WriteLine("b lon hon a");
            }
        }
    }
}
