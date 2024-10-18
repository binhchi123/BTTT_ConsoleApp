using System;
using System.Collections.Generic;

namespace b22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 22, 333, 444 };
            Console.WriteLine("Cac phan tu trong danh sach");
            foreach (int i in list) 
            { 
                Console.Write(i + " ");
            }
        }
    }
}
