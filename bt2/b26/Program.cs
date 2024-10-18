using System;
using System.Collections.Generic;

namespace b26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> C = new List<string>() 
            { "Cam", "Quyt", "Mit", "Dua", "Dua", "Le", "Tao", "Oi"};
            C.Sort();
            Console.WriteLine($"Danh sach sau khi sap xep: {string.Join(", ", C)}");
        }
    }
}
