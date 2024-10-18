using System;

namespace b41
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Nhap chuoi a: ");
            string a = Console.ReadLine();
            Console.Write("Nhap chuoi b: ");
            string b = Console.ReadLine();
            if (a.Contains(b))
            {
                Console.WriteLine("Tim thay chuoi con trong chuoi a");
            }
            else
            {
                Console.WriteLine("Khong tim thay");
            }
        }
    }
}
