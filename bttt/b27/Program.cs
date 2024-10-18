using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số nguyên dương n<50: ");
            int n = Convert.ToInt32(Console.ReadLine());
           
            double tich = 1;
            for(int i = 1; i < n; i++)
            {
                double sqrt = Math.Sqrt(i);
                tich *= Math.Sqrt(i);
                
            }
            Console.WriteLine($"Tich cac so chinh phuong: {tich}");
        }
    }
}
