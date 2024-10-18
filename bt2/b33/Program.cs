using System;

namespace b33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "  tran   van  a ";
            int count = 0;
            foreach (char c in text) { 
                if(c == ' ') { 
                    count++;
                }
            }
            Console.WriteLine($"So khoang trang: {count}");
        }
    }
}
