using System;
using System.Linq;

namespace b13
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
            int[] chan = arr.Where(c => c % 2 == 0).ToArray();
            int[] le = arr.Where(c => c % 2 != 0).ToArray();
            Array.Sort(chan);
            Array.Sort(le);
            Array.Reverse(le);
            int[] result = new int[n];
            int index = 0;
            foreach (int num in chan)
            {
                result[index++] = num;
            }
            foreach (int num in le)
            {
                result[index++] = num;
            }
            Console.WriteLine($"Mang da sap xep: [{string.Join(", ", result)}]");
        }
    }
}
