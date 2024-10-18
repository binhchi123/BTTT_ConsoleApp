using System;

namespace b42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi a: ");
            string a = Console.ReadLine();
            int length = a.Length;
            Console.WriteLine($"Do dai cua chuoi la: {length}");
        }
    }
}
