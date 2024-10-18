using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ki tu: ");
            char kytu = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.IsLetterOrDigit(kytu))
            {
                Console.WriteLine($"Ky tu {kytu} khong la mot ky tu dac biet");
            }
            else
            {
                Console.WriteLine($"Ky tu {kytu} la mot ky tu dac biet");
            }
        }
    }
}
