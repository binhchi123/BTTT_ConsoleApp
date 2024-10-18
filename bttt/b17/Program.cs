using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b17
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
            if (a>0 && b>0 && c>0 && (a + b + c) == 180)
            {
                if(a ==  b && b == c &&  c == a)
                {
                    Console.WriteLine("Day la tam giac deu");
                   
                }
                if(a==b || b==c || c== a)
                {
                    Console.WriteLine("Day la tam giac can");
                }
                if(a == 90 || b == 90 || c == 90)
                {
                    Console.WriteLine("Day la tam giac vuong");
                }
                else
                {
                    Console.WriteLine("Day la tam giac thuong");
                }
            }
            else
            {
                Console.WriteLine("Khong phai la tam giac");
            }

        }
    }
}
