using System;
using System.Security.Cryptography;

namespace b38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Random();
            Console.WriteLine($"So sinh ngau nhien la: {n}");

        }
        static int Random()
        {
            Random random = new Random();
            return random.Next();
        }
    }
}
