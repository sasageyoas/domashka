using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace def
{
    internal class palindrom
    {
        static void palin(string text)
        {
            string result;
            text = text.ToLower();
            bool isPalindrome = text == new string(text.Reverse().ToArray());
            if (isPalindrome)
            {
                result = "является";
            }
            else
            {
                result = "не является";
            }

            Console.WriteLine($"Слово {text} {result} паллиндромом");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово");
            string text = Console.ReadLine();
            palin(text);
        }
    }
}