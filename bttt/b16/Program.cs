using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so nguyen b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so nguyen c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int max = a;
            if(b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            Console.WriteLine($"So lon nhat la: {max}");
        }
    }
}
