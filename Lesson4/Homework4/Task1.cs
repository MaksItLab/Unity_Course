using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpersLibrary;

namespace Homework4
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10000, 10000);
            }
            int count = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (((array[i] % 3 == 0) && !(array[i-1] % 3 == 0)) || !(array[i] % 3 == 0) && (array[i - 1] % 3 == 0))
                {
                    Helpers.Out($"{array[i-1]}, {array[i]}   ");
                    count++;
                }
            }

            Helpers.OutLine($"\nCount of pairs = {count}");
            Helpers.Enter();
        }
    }
}
