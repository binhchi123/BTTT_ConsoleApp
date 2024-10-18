using System;

namespace b40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi 1: ");
            string chuoi1 = Console.ReadLine();
            Console.Write("Nhap chuoi 2: ");
            string chuoi2 = Console.ReadLine();
            if (String.Compare(chuoi1, chuoi2, true) == 0) {
                Console.WriteLine("Giong nhau, khong phan biet hoa thuong");
            }
            else {
                Console.WriteLine("Khong giong nhau, khong phan biet hoa thuong");
            }
        }
    }
}
