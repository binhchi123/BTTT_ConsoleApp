using System;

namespace b43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi 1: ");
            string chuoi1 = Console.ReadLine();
            Console.Write("Nhap chuoi 2: ");
            string chuoi2 = Console.ReadLine();
            if (String.Compare(chuoi1, chuoi2, true) > 0)
            {
                Console.WriteLine("Chuoi 1 lon hon chuoi 2");
            }
            else if(String.Compare(chuoi1, chuoi2, true) < 0)
            {
                Console.WriteLine("Chuoi 1 nho hon chuoi 2");
            }
        }
    }
}
