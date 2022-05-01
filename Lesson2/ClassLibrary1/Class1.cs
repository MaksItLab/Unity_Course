using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studing.Utils
{
    public class Helpers
    {
        public static void Print(string str)
        {
            Console.Write($"{str}");
        }
        public static void Print(int number)
        {
            Console.Write(number);
        }
        public static void PrintLine(string str)
        {
            Console.WriteLine($"{str}");
        }
        public static void PrintLine(int number)
        {
            Console.WriteLine(number);
        }
        public static void PrintLine(long number)
        {
            Console.WriteLine(number);
        }


        public static void Pause()
        {
            Console.ReadLine();
        }

        public static string Enter()
        {
            return Console.ReadLine();
        }
    }
}
