using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Введите строку");
            str = Console.ReadLine();
            string new_str = "";
            while (str.Contains("{"))
            {
                int delta = str.IndexOf("}") - str.IndexOf("{");
                str = str.Remove(str.IndexOf("{"), delta + 1);
            }
            foreach (char c in str)
            {
                if (c == '}')
                {
                    str = str.Remove(str.IndexOf(c), 1);
                }
            }

            Console.WriteLine(str);
            Console.ReadKey();

        }
    }
}
