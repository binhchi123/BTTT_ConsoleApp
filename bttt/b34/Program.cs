using System;

namespace b34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong n: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int n) && n > 0)
            {
                bool le = check(n);
                if (le)
                {
                    Console.WriteLine("Toan so le");
                }
                else
                {
                    Console.WriteLine("Khong phai la so le");
                }
            }
            else
            {
                Console.WriteLine("Hay nhap mot so nguyen");
            }
        }
        static bool check(int n)
        {
            
            while (n > 0)
            {
                int t = n % 10;
                if (t % 2 == 0)
                {
                    return false;
                }
                n /= 10;
            }
            return true;
        }
    }
}
