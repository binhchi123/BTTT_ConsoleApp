using System;
using System.Collections.Generic;

namespace b29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,3,4,5,-1,-2,-5,7,8,9};
            for (int i = 0; i < list.Count; i++) {
                if (list[i] < 0)
                {
                    list[i] = 0;                    
                }
            }
            Console.WriteLine($"Danh sach ket qua: {string.Join(", ", list)}");
        }
    }
}
