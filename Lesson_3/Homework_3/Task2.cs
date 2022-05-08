using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryHelp;

namespace Homework_3
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            List<int> list = new List<int>();

            while (true)
            {
                Helpers.OutLine("Enter numbers");
                if (int.TryParse(Helpers.Enter(), out number))
                {
                    if (number == 0) break;
                    else if (number > 0 && number % 2 != 0)
                    {
                        list.Add(number);
                        sum += number;
                    }
                }
            }

            OutData(list);

            Helpers.OutLine($"Sum of numbers: {sum}");
        }

        public static void OutData(List<int> list)
        {
            Helpers.Out("List of numbers: ");
            for (int i = 0; i < list.Count; i++)
            {
                Helpers.Out($"{list[i]} ");
            }
            Helpers.OutLine("");
        }
    }
}
