using System;

namespace b7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 1, 4, 7, 8, 9, 6, 3, 2, 5};
            double total = 0;
            double avg = 0;
            for (int i = 0; i<arr.Length; i++) {
                total += arr[i];
            }
            Console.Write("Cac phan tu trong mang la: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");             
            }
            avg = total / arr.Length;
            Console.WriteLine();
            Console.WriteLine($"Gia tri trung binh trong mang la: {avg}");
        }
    }
}
