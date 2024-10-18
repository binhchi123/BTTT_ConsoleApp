using System;

namespace b47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string chuoi;
            while (true) {
                Console.WriteLine("Nhap chuoi: ");
                chuoi = Console.ReadLine();
                if(chuoi.Length <= n)
                {
                    break;
                }
                else
                {
                    Console.Write("Qua so luong ky tu cho phep");
                }
            }
            Console.WriteLine($"Chuoi nhap duoc: {chuoi}");
        }
    }
}
