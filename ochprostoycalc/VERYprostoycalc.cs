using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"сложение = {a + b}");
            Console.WriteLine($"вычитание = {a - b}");
            if (b == 0)
            {
                Console.WriteLine("нини, деление на ноль!");
                Console.WriteLine("нини, деление на ноль!");
            }
            else
            {
                Console.WriteLine($"деление с остатком = {a % b}");
                Console.WriteLine($"деление без остатка = {a / b}");

            }
            Console.WriteLine($"умножние = {a * b}");

        }
    }
}