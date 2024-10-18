using System;

namespace b39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string chuoi = Console.ReadLine();
            int count = 0;
            foreach (char c in chuoi) 
            {
                if (c == ' ') {
                    count++;
                }
            }
            Console.WriteLine($"So khoang trang trong chuoi: {count}");
        }
    }
}
