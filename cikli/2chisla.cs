using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ymnozhenie
{
    static class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Введите первое число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите второе число: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 >= 0 && num1 <= 10 && num2 >= 0 && num2 <= 10)
                {
                    Console.WriteLine($"Результат умножения: {num1 * num2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка: числа должны быть в диапазоне от 0 до 10. Попробуйте снова.");
                }
            }
        }
    }
}