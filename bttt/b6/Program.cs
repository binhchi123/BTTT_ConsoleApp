using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ho va ten: ");
            string name = Console.ReadLine();           
            Console.Write("Nhap ngay sinh (dd/MM/yyyy): ");
            DateTime birthday = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            DateTime nghihuu = birthday.AddYears(60);
            Console.WriteLine($"Ho va ten: {name}");
            Console.WriteLine($"Ngay ve huu: {nghihuu}");
        }
    }
}
