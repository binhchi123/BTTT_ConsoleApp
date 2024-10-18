using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap diem toan: ");
            double toan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem van: ");
            double van = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem anh: ");
            double anh = Convert.ToDouble(Console.ReadLine());
            double avg = (toan + van + anh)/3;
            Console.WriteLine($"Diem trung binh: {avg}");
            if (avg <= 4)
            {
                Console.WriteLine("Hoc luc yeu");
            }
            else if(avg >4 && avg <= 6.5)
            {
                Console.WriteLine("Hoc luc trung binh");
            }
            else if (avg > 6.5 && avg <= 8)
            {
                Console.WriteLine("Hoc luc kha");
            }
            else if (avg > 8 && avg <= 9)
            {
                Console.WriteLine("Hoc luc gioi");
            }
            else if (avg > 9)
            {
                Console.WriteLine("Hoc luc xuat sac");
            }
        }
    }
}
