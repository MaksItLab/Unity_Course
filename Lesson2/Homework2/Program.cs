using Studing.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            bool stop = false;
            while (!stop)
            {
                Helpers.PrintLine("Enter number of task(1-7): ");
                int numberTask = int.Parse(Helpers.Enter());
                switch (numberTask)
                {
                    case 1:
                        Task1();
                        break;

                    case 2:
                        Task2();
                        break;

                    case 3:
                        Task3();
                        break;

                    case 4:
                        Task4();
                        break;

                    case 5:
                        Task5();
                        break;

                    case 6:
                        Task6();
                        break;

                    case 7:
                        Task7();
                        break;

                    default:
                        Helpers.PrintLine("Enter correct data");
                        break;
                }

            }

        }
        public static void Task1()
        {
            Helpers.PrintLine("===============Task_1===============");
            Helpers.PrintLine("Enter the first number");
            int a = int.Parse(Helpers.Enter());
            Helpers.PrintLine("Enter the second number");
            int b = int.Parse(Helpers.Enter());
            Helpers.PrintLine("Enter the third number");
            int c = int.Parse(Helpers.Enter());
            Helpers.PrintLine("The min number is " + Comparsion(a, b, c));
            Helpers.PrintLine("====================================");
        }
        public static void Task2()
        {
            Helpers.PrintLine("===============Task_2===============");
            Helpers.PrintLine("Enter the number");
            int a = int.Parse(Helpers.Enter());
            Helpers.PrintLine("Quantity of number is " + QuantityNumber(a));
            Helpers.PrintLine("====================================");
        }
        public static void Task3()
        {
            Helpers.PrintLine("===============Task_3===============");
            Helpers.PrintLine("Enter the numbers");
            int a;
            int sum = 0;
            for (int i = 0; ; i++)
            {
                a = int.Parse(Helpers.Enter());
                if (a == 0) break;
                if (a > 0 && a % 2 != 0) sum += a;
            }
            Helpers.PrintLine("The sum is " + sum);
            Helpers.PrintLine("====================================");
        }
        public static void Task4()
        {
            Helpers.PrintLine("===============Task_4===============");
            Examination();
            Helpers.PrintLine("====================================");
        }
        public static void Task5()
        {
            // <18.5; Small weight
            // 18.5 - 25; Normal
            // >25; Big weight
            Helpers.PrintLine("===============Task_5===============");
            Helpers.Print("Enter weight: ");
            int weight = int.Parse(Helpers.Enter());
            Helpers.Print("Enter height(For example: 1,83): ");
            double height = double.Parse(Helpers.Enter());
            double IWB = weight / Math.Pow(height, 2);
            if (IWB < 18.5) Helpers.PrintLine($"Small weight, gain {(18.5 * Math.Pow(height, 2) - IWB * Math.Pow(height, 2)):F3} kilograms");
            else if (IWB >= 18.5 && IWB <= 25) Helpers.PrintLine($"You have a normal weight");
            else if (IWB > 25) Helpers.PrintLine($"Big weight, lose {(IWB * Math.Pow(height, 2) - 25 * Math.Pow(height, 2)):F3} kilograms");
            Helpers.PrintLine("====================================");
        }
        public static void Task6()
        {
            Helpers.PrintLine("===============Task_6===============");
            int count = 0;
            int sum = 0;
            DateTime date1 = DateTime.Now;
            for (int i = 1; i <= 1000000000; i++)
            {
                Helpers.PrintLine(i);
                int index = i;
                while (i != 0)
                {
                    sum += i % 10;
                    i /= 10;
                }
                i = index;
                if (i % sum == 0)
                {
                    count++;
                }
                sum = 0;
            }
            DateTime date2 = DateTime.Now;
            Console.WriteLine("Time elapsed: " + (date2.Millisecond - date1.Millisecond) + " millisecond");
            Helpers.PrintLine($"Quantity of good number: {count}");
            Helpers.PrintLine("====================================");
        }
        public static void Task7()
        {
            Helpers.PrintLine("===============Task_7===============");
            Helpers.PrintLine("The second number is greater than the first number");
            Helpers.PrintLine("Enter the first number");
            int firstNumber = int.Parse(Helpers.Enter());
            Helpers.PrintLine("Enter the second number");
            int secondNumber = int.Parse(Helpers.Enter());
            Function(firstNumber, secondNumber);
            FunctionSum(firstNumber, secondNumber);
            Helpers.PrintLine($"\nThe sum is {sum}");
            Helpers.PrintLine("====================================");
        }

        public static int sum = 0;
        public static void Function(int a, int b)
        {
            if (b > a)
            {
                Function(a, b - 1);
            }
            Helpers.Print(b + " ");
        }
        public static void FunctionSum(int a, int b)
        {
            if (b > a)
            {
                FunctionSum(a, b - 1);
            }
            sum += b; ;
        }
        public static int Comparsion(int x, int y, int z)
        {
            int min = x < y ? (x < z ? x : z) : (y < z ? y : z);
            return min;
        }
        public static int QuantityNumber(int x)
        {
            int count = 0;
            while (x != 0)
            {
                count++;
                x /= 10;
            }
            return count;
        }
        public static void Examination()
        {
            int count = 1;
            do
            {
                Console.WriteLine($"Attempt {count}");
                Helpers.Print("Enter login: ");
                string login = Helpers.Enter();
                Helpers.Print("Enter password: ");
                string password = Helpers.Enter();
                if (login == "root" && password == "GeekBrains")
                {
                    Helpers.PrintLine("Data is correct");
                    break;
                }
                Helpers.PrintLine("Data isn't correct");
                count++;
            }
            while (count != 4);
        }
    }
}
