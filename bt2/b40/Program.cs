using System;

namespace b40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string chuoi = Console.ReadLine();
            string chuanHoa = ChuanHoa(chuoi);
            Console.WriteLine($"Chuoi sau khi chuan hoa: {chuanHoa}");
        }
        static string ChuanHoa(string chuoi)
        {
            chuoi = chuoi.Trim();
            string[] words = chuoi.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" ", words);
        }
    }
}
