using System;

namespace b18
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
            int index = -1;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 10 == 0)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                Console.WriteLine($"So dau tien chia het cho 10 la {arr[index]} o vi tri {index}");
            }
            else 
            {
                Console.WriteLine("Khong co so nao chi het cho 10");
            }
        }
    }
}
