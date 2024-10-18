using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b10
{
    class Program
    {
        static void Main(string[] args)
        {
            string acc = "nguyendongkhanh@hvitclan.vn";
            string pw = "123456";
            Console.Write("Nhap tai khoan: ");
            string account = Console.ReadLine();
            Console.Write("Nhap mat khau: ");
            string password = Console.ReadLine();
            if(acc == account && pw == password)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
