using System;

namespace b30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            while (true)
            {
                Console.Write("Nhap so a (tu 1 den 100): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out a))
                {
                    if (a >= 1 && a <= 100)
                    {
                        Console.WriteLine($"So a ban da nhap la: {a}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nhap sai! Moi nhap lai:");
                    }
                }
                else
                {
                    Console.WriteLine("Nhap sai! Moi nhap lai:");
                }
            }
        }
    }
}
