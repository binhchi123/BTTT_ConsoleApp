using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so hang m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap so cot n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Nhap phan tu tai vi tri [{i},{j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Ma tran da nhap:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
