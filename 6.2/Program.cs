using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string back_str;
            back_str = "";

            string str = Console.ReadLine();
            str = str.ToLower();

            string[] strArray = str.Split();

            foreach (string s in strArray)
            {
                foreach (char c in s)
                {
                    back_str = c + back_str;
                }
            }

            str = str.Replace(" ", "");
            if (back_str == str)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }
            Console.WriteLine("Перевернутая строка: {0}", back_str);
            Console.WriteLine("Исходная строка: {0}", str);
            Console.ReadKey();
        }
    }
}
