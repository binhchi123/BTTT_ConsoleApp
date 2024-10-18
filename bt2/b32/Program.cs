using System;
using System.Collections.Generic;

namespace b32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.Write("Nhap cac chuoi: ");
            while (true) {
                string chuoi = Console.ReadLine();
                if (chuoi.ToLower() == "exit")
                {
                    break;
                }
                list.Add(chuoi);
            }
            Console.WriteLine($"Danh sach ket qua: {string.Join(", ", list)}");
        }
    }
}
