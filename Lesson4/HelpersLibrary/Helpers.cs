using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelpersLibrary
{
    public class Helpers
    {
        public static void Out(object str)
        {
            Console.Write(str);
        }

        public static void OutLine(object str)
        {
            Console.WriteLine(str);
        }

        public static string Enter()
        {
            return Console.ReadLine();
        }
    }
}
