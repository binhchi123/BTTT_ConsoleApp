using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ki tu: ");          
            char kytu = Console.ReadKey().KeyChar;
            Console.WriteLine();
            string nguyenam = "aeiou";
            if (char.IsLetter(kytu)) {
                if(nguyenam.IndexOf(kytu) >= 0)
                {
                    Console.WriteLine($"Ky tu {kytu} la nguyen am");
                }
                else
                {
                    Console.WriteLine($"Ky tu {kytu} la phu am");
                }
            }
            else
            {
                Console.WriteLine("Khong phai nguyen am va phu am");
            }
        }
    }
}
