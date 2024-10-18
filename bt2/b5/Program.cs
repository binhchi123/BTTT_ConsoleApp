using System;
using System.Linq;

namespace b5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi ky tu: ");
            string chuoi = Console.ReadLine();
            char[] charArr = chuoi.ToCharArray();
            Array.Reverse(charArr);
            string reverseString = new string(charArr);
            Console.Write($"Mang dao nguoc: {reverseString}");
        }
    }
}
