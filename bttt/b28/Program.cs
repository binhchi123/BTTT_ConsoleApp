using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool isPrime = IsPrime(n);
            Console.WriteLine(isPrime);
        }
        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
