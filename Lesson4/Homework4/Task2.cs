using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpersLibrary;
using System.IO;

namespace Homework4
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Helpers.OutLine("a: ");
            MyArray.PairElements(arr);


            Helpers.OutLine("\nb: ");
            Helpers.OutLine("Enter the name of file: "); // TextFile1.txt
            try
            {
                string file = Helpers.Enter();
                MyArray array1 = new MyArray(file);
                array1.OutArray();
            }
            catch (FileNotFoundException)
            {
                Helpers.OutLine("File not found");
            }

            Helpers.OutLine("\nClick to go to the next task");
            Helpers.Enter();

            int[] arr2 = new int[20];
            Helpers.OutLine("Enter initial value: ");
            int baseValue = int.Parse(Helpers.Enter());
            Helpers.OutLine("Enter step: ");
            int step = int.Parse(Helpers.Enter());
            MyArray myArray3 = new MyArray(arr2, baseValue, step);
            myArray3.OutArray();

            Helpers.OutLine("\nClick to continue");
            Helpers.Enter();

            Helpers.OutLine("Введите число, на которое хотите умножить элементы массива: ");
            int multiValue = int.Parse(Helpers.Enter());
            int[] arr4 = new int[5] { 1, 2, 3, 4, 5 };
    
            MyArray.Multi(arr4, multiValue);

            for (int i = 0; i < arr4.Length; i++)
            {
                Helpers.Out(arr[i] + " ");
            }
            Helpers.Enter();

        }
    }

    class MyArray
    {

        int[] arr;

        public int Sum
        {
            get 
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }
        }


        public MyArray(int[] arr, int baseValue, int step)
        {
            this.arr[0] = baseValue;
            for (int i = 1; i < arr.Length; i++)
            {
                this.arr[i] = arr[i - 1] + step;
            }
        }

        public MyArray()
        {
            
        }
        public MyArray(string filename)
        {
            this.arr = ArrayFromFile(filename);
        }

        public static int[] Inverse(int[] array)
        {
            int[] array1 = new int[array.Length];
            Array.Copy(array, array1, array.Length);
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] *= -1;
            }
            return array1;
        }

        public static void Multi(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= value; 
            }
        }

        public static int[] ArrayFromFile(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            int[] buf = new int[1000];
            int counter = 0;
            StreamReader sr = new StreamReader(filename);

            while (!sr.EndOfStream)
            {
                buf[counter] = int.Parse(sr.ReadLine());
                counter++;
            }
            sr.Close();
            int[] arr = new int[counter];

            Array.Copy(buf, arr, counter);

            return arr;
        }

        public static void PairElements(int[] arr)
        {
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-10000, 10000);
            }
            int count = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (((arr[i] % 3 == 0) && !(arr[i - 1] % 3 == 0)) || !(arr[i] % 3 == 0) && (arr[i - 1] % 3 == 0))
                {
                    Helpers.Out($"{arr[i - 1]}, {arr[i]} ");
                    count++;
                }
            }

            Helpers.OutLine($"\nCount of pairs = {count}");
        }

        public void OutArray()
        {
            for (int i = 0; i < this.arr.Length; i++)
            {
                Helpers.OutLine(this.arr[i]);
            }
        }
    }
}
