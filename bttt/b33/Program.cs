using System;

namespace b33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong n: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int n) && n > 0) 
            {
                bool sort = check(n);
                Console.WriteLine(sort);
            }
            else
            {
                Console.WriteLine("Hay nhap mot so nguyen");
            }
        }

        static bool check(int n)
        {
            int sotruoc = 10;       
            while (n > 0)
            {
                int sohtai = n % 10; 
                if (sohtai >= sotruoc) 
                {
                    return true; 
                }
                sotruoc = sohtai;
                n /= 10; 
            }
            return false; 
        }
    }
}
