using System;

namespace b4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string chuoi = Console.ReadLine();
            Console.Write("Nhap ky tu can dem: ");
            char charCount = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int count = 0;
            foreach (var c in chuoi)
            {
                if (charCount == c)
                {
                    count++;
                }
            }
            Console.WriteLine($"Ky tu {charCount} xuat hien {count} lan");
        }
    }
}
