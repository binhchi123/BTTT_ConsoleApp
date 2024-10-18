using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu cao (cm): ");
            double chieucao = Convert.ToDouble(Console.ReadLine());
            if (chieucao < 145)
            {
                Console.WriteLine("Rat lun");
            }
            else if (chieucao < 150)
            {
                Console.WriteLine("Lun");
            }
            else if (chieucao >= 150 && chieucao < 170)
            {
                Console.WriteLine("Binh thuong");
            }
            else if (chieucao >= 170 && chieucao <= 180)
            {
                Console.WriteLine("Cao");
            }
            else if (chieucao > 180)
            {
                Console.WriteLine("Rat cao");
            }
        }
    }
}
