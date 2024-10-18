using System;
using System.Collections.Generic;

namespace b11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "abc", "abcd", "abcde", "abcdef" };
            int total = 0;
            List<int> lengths = new List<int>();
            foreach (string str in arr)
            {
                int length = str.Length;
                lengths.Add(length);
                if(length % 2 != 0 ){
                    total+= length;
                }
            }          
            Console.WriteLine($"Do dai cac chuoi: {string.Join(", ", lengths)}");
            Console.WriteLine($"Tong do dai cua chuoi le trong mang: {total}");
        }
    }
}
