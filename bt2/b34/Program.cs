using System;

namespace b34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double result = Tich(a, b);
            Console.WriteLine($"Ket qua: {result}");
        }
        static double Tich(double a, double b) 
        { 
            return a * b; 
        }
    }
}
