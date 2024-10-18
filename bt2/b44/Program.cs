using System;

class MatrixMultiplication
{
    static void Main()
    {
        Console.WriteLine("Nhập số hàng của ma trận A:");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập số cột của ma trận A:");
        int n = int.Parse(Console.ReadLine());
        int[,] A = new int[m, n];
        Console.WriteLine("Nhập các phần tử của ma trận A:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Nhập số hàng của ma trận B:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập số cột của ma trận B:");
        int q = int.Parse(Console.ReadLine());
        int[,] B = new int[p, q];
        Console.WriteLine("Nhập các phần tử của ma trận B:");
        for (int i = 0; i < p; i++)
        {
            for (int j = 0; j < q; j++)
            {
                B[i, j] = int.Parse(Console.ReadLine());
            }
        }
        if (n != p)
        {
            Console.WriteLine("Vi pham nguyen tac nhan ma tran");
        }
        else
        {
            int[,] C = new int[m, q];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    C[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
            Console.WriteLine("Ma trận tích C:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
