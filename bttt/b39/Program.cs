using System;

namespace b39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ngay sinh (dd/MM/yyyy): ");
            DateTime day = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.WriteLine($"Ngay thang nam vua nhap: {day}");
        }
    }
}
