using System;

namespace b38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi ho ten: ");
            string fullName = Console.ReadLine();
            int letterCount = CountLetters(fullName);
            Console.WriteLine($"Chuoi \"{fullName}\" co {letterCount} chu cai.");
        }
        static int CountLetters(string str)
        {
            int count = 0;

            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    count++;
                }
            }

            return count; 
        }
    }
}
