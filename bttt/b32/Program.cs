using System;

namespace b32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong n: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int n) && n > 0)
            {
                int tich = 1;
                string multiplicationExpression = ""; 

                while (n > 0)
                {
                    int digit = n % 10;
                    tich *= digit; 
                    multiplicationExpression = digit + multiplicationExpression; 

                    n /= 10;
                    if (n > 0) 
                    {
                        multiplicationExpression = "x" + multiplicationExpression;
                    }
                }

                Console.WriteLine($"{multiplicationExpression} = {tich}");
            }
            else
            {
                Console.WriteLine("Hay nhap mot so nguyen");
            }
        }
    }
}
