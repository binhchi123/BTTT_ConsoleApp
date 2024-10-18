using System;

namespace b29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int uscln = USCLN(a,b);
            int bscnn = BSCNN(a,b);
            Console.WriteLine($"USCLN: {uscln} va BSCNN: {bscnn}");

        }

        static int USCLN(int a, int b)
        {
            if(b== 0) return a;
            return USCLN(b, a%b);
        }

        static int BSCNN(int a, int b)
        {
            return a*b/USCLN(a,b);
        }
    }
}
