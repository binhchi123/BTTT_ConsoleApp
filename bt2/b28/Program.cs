using System;
using System.Collections.Generic;

namespace b28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Nguyen Duc Toan", "Nguyen Hoang Truong", "Nguyen Dong Khanh"};
            Console.WriteLine($"Danh sach: {string.Join(", ", list)}");
            Console.Write("Do dai chuoi muon nhap: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> result = new List<string>();
            foreach (string s in list) 
            { 
                if(s.Length > n) result.Add(s);
            }
            Console.WriteLine($"Danh sach ket qua: {string.Join(", ", result)}");
        }
    }
}
