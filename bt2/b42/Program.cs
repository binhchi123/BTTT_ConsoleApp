using System;

namespace b42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chuoi: ");
            string chuoi = Console.ReadLine();
            string ktgiua = Mid(chuoi);
            Console.WriteLine($"Ky tu giua chuoi la: {string.Join(", ", ktgiua)}");
        }
        static string Mid( string chuoi)
        {
            int midIndex = chuoi.Length / 2;
            if (midIndex % 2 != 0)
            {
                return chuoi[midIndex].ToString();
            }
            else
            {
                return chuoi.Substring(midIndex - 1, 2);
            }
        }
    }
}
