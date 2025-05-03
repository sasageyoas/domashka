using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace def
{
    internal class deldup
    {
        static void clear(int[] array)
        {
            List<int> new_list = new List<int>();
            foreach (int num in array)
            {
                if (!new_list.Contains(num))
                {
                    new_list.Add(num);
                }
            }

            foreach (int num in new_list)
            {
                Console.Write(num + " ");
            }

        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 3, 5, 5, 6, 7, 8, 7, 9, 10 };

            clear(array);


        }
    }
}