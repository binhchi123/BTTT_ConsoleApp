using System;
using System.Collections.Generic;

namespace b24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8};
            Console.WriteLine($"Danh sach: {string.Join(", ", list)}");
            Console.Write("Nhap so nguyen can tim: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (list.Contains(x)) 
            { 
                list.Remove(x);
                Console.WriteLine($"Danh sach sau khi xoa: {string.Join(", ", list)}");
            }
            else
            {
                Console.WriteLine("Phan tu khong ton tai trong danh sach");
            }
        }
    }
}
