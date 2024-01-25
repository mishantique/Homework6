using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str, max;
            Console.WriteLine("Введите строку");
            str = Console.ReadLine();

            string[] strArray = str.Split();
            max = strArray[0];

            foreach (string s in strArray)
            {
                if (s.Length > max.Length)
                {
                    max = s;
                }
            }
            Console.WriteLine("Саммое длинное слово: {0}", max);
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
        }
    }
}
