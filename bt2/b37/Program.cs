using System;

namespace b37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Input();
            Console.Write($"So vua nhap la: {n}");
        }
        static int Input()
        {
            int result;
            while (true) {
                Console.Write("Nhap so nguyen n: ");
                string n = Console.ReadLine();
                if (int.TryParse(n, out result)){
                    return result;
                }
                else
                {
                    Console.WriteLine("Sai quy cach. Nhap lai");
                }
            }
        }
    }
}
