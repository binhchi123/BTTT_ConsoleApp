using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao chuoi: ");
            string chuoi = Console.ReadLine();
            int letterCount = 0;
            int digitCount = 0;
            int specialCharCount = 0;

            // Duyệt qua từng ký tự trong chuỗi
            foreach (char c in chuoi)
            {
                if (char.IsLetter(c)) // Kiểm tra nếu là chữ cái
                {
                    letterCount++;
                }
                else if (char.IsDigit(c)) // Kiểm tra nếu là chữ số
                {
                    digitCount++;
                }
                else if (!char.IsWhiteSpace(c)) // Kiểm tra nếu không phải là khoảng trắng
                {
                    specialCharCount++;
                }
            }
            Console.WriteLine($"Chuoi \"{chuoi}\" co {digitCount} chu so, {letterCount} chu cai va {specialCharCount} ky tu.");
        }
    }
}
