﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcccc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, res;
                string c;
                Console.Write("Введите первое число: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите знак: ");
                c = Console.ReadLine();
                if (c == "+")
                {
                    res = a + b;
                    Console.Write($"Результат = {res}");
                }
                else if (c == "-")
                {
                    res = a - b;
                    Console.Write($"Результат = {res}");
                }
                else if (c == "*")
                {
                    res = a * b;
                    Console.Write($"Результат = {res}");
                }
                else if (c == "/")
                {
                    res = a / b;
                    Console.Write($"Результат = {res}");
                }
                else if (c == "%")
                {
                    res = a / b;
                    Console.Write($"Результат = {res}");
                }
                else if (c == "&")
                {
                    res = a & b;
                    Console.Write($"Результат = {res}");
                }
                else if (c == "|")
                {
                    res = a | b;
                    Console.Write($"Результат = {res}");
                }
                else if (c == "^")
                {
                    res = a ^ b;
                    Console.Write($"Результат = {res}");
                }
                else
                {
                    Console.WriteLine("нинини!!! так нельзя!! атата!!");
                }
            }
            catch
            {
                Console.WriteLine("нинини!!! бить больна неправильное значение!!");
            }
        }
    }
}