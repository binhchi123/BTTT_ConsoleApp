using System;
using System.Collections.Generic;

namespace b23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>() 
            { "Nguyen Duc Toan", "Nguyen Hoang Truong", "Nguyen Dong Khanhh" };
            List<string> daoNguoc = new List<string>(strings);
            daoNguoc.Reverse();
            foreach (string s in daoNguoc) 
            {
                Console.Write(s + " ");
            }           
        }
    }
}
