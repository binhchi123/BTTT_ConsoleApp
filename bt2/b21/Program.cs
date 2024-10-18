using System;

namespace b21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ho va ten: ");
            string name = Console.ReadLine();
            string email = CreateEmail(name);
            Console.WriteLine($"Email: {email}");
        }
        static string CreateEmail(string name)
        {
            string[] parts = name.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 2)
            {
                return "Chuỗi không hợp lệ!";
            }
            string firstName = parts[parts.Length - 1];
            string lastName = "";
            for (int i = 0; i < parts.Length - 1; i++)
            {
                lastName += parts[i][0];
            }
            string email = $"{firstName}{lastName}".ToLower() + "@hvitclan.vn";
            return email;
        }
    }
}
