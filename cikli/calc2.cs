using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сумму вклада: ");
            decimal deposit = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Введите количество месяцев: ");
            int months = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            while (i < months)
            {
                deposit += deposit * 0.07m;
                i++;
            }

            Console.WriteLine($"Конечная сумма вклада: {deposit:F2}");
        }
    }
}
