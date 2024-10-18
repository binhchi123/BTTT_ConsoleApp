using System;

namespace b1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {2, 3, 4, 5, 6};
            Console.Write("Cac phan tu trong mang: ");
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++) { 
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
    }
}
