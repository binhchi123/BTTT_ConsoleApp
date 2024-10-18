using System;

namespace b36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            Console.Write("Nhap so hang: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                /* vong lap nay de in khoang trang */
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                /* Hien thi cac so theo thu tu tang dan tu dau hang cho den giua hang*/
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", j);

                /* Hien thi so theo thu tu giam dan tu giua hang cho den cuoi hang */
                for (j = i - 1; j >= 1; j--)
                    Console.Write("{0}", j);

                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
