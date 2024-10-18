using System;
using System.Collections.Generic;

namespace b41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Nguyen Duc Toan", "Nguyen Hoang Truong", "Nguyen Dong Khanh" };
            List<string> daoNguoc = new List<string>(list);
            daoNguoc.Reverse();
            foreach (string s in daoNguoc)
            {
                Console.Write(s + ", ");
            }
        }
    }
}
