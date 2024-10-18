using System;
using System.Collections.Generic;

namespace b14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Nhap cac phan tu mang:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Phan tu {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            List<int> le = new List<int>();
            foreach (int num in arr)
            {
                if (num % 2 != 0)
                {
                    le.Add(num);
                }
            }
            le.Sort();
            int[] result = new int[n];
            int leIndex = 0;
            for (int i = 0; i < n; i++) 
            {             
                if(arr[i] % 2 != 0)
                {
                    result[i] = le[leIndex++]; 
                }
                result[i] = arr[i];
            }
            Console.WriteLine($"Mang da sap xep: [{string.Join(", ", result)}]");
        }
    }
}
