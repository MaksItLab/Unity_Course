using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryHelp
{
    public class Helpers
    {
        public static void Pause()
        {
            Console.ReadLine();
        }

        public static string Enter()
        {
            return Console.ReadLine();
        }

        public static void Out(object x)
        {
            Console.Write(x);
        }

        public static void OutLine(object x)
        {
            Console.WriteLine(x);
        }
    }
}
