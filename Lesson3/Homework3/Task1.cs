using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryHelp;

namespace Homework3
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            bool func = false;
            int action;

            ComplexStruct complex1;
            ComplexStruct complex2;

            Helpers.OutLine("Enter the real part of the first number");
            complex1.re = double.Parse(Helpers.Enter());
            Helpers.OutLine("Enter the imaginary part of the first number");
            complex1.im = double.Parse(Helpers.Enter());
            Helpers.OutLine("Enter the real part of the second number");
            complex2.re = double.Parse(Helpers.Enter());
            Helpers.OutLine("Enter the imaginary part of the second number");
            complex2.im = double.Parse(Helpers.Enter());

            ComplexClass complexClass1 = new ComplexClass();
            complexClass1.Re = complex1.re;
            complexClass1.Im = complex1.im;

            ComplexClass complexClass2 = new ComplexClass();
            complexClass2.Re = complex2.re;
            complexClass2.Im = complex2.im;

            while (!func)
            {   
                Helpers.OutLine("1. Structure addition\n" +
                                "2. Structure subtruction\n" +
                                "3. Class subtruction\n" +
                                "4. Class multi");
                action = int.Parse(Helpers.Enter());

                switch (action)
                {
                    case 1:
                        ComplexPlusOut(complex1, complex2);
                        break;

                    case 2:
                        ComplexSubtractionOut(complex1, complex2);
                        break;

                    case 3:
                        ComplexClass.SubtractionOut(complexClass1, complexClass2);
                        break;

                    case 4:
                        ComplexClass.MultiOut(complexClass1, complexClass2);
                        break;

                    default:
                        Helpers.OutLine("Enter correct data");
                        break;
                }

                Helpers.OutLine("Do you want to continue?");
                if (Console.ReadLine() == "no" || Console.ReadLine() == "нет")
                {
                    func = true;
                }
            }
        }

        public static void ComplexPlusOut(ComplexStruct x, ComplexStruct y)
        {
            ComplexStruct res;
            res = x.ComplexPlus(y);
            Helpers.OutLine($"{x} + {y} = {res}");
        }

        public static void ComplexSubtractionOut(ComplexStruct x, ComplexStruct y)
        {
            ComplexStruct res;
            res = x.ComplexSubtraction(y);
            Helpers.OutLine($"{x} - ({y}) = {res}");
        }

        public struct ComplexStruct
        {
            public double re;
            public double im;

            public override string ToString()
            {
                return $"{re} + {im}i";
            }
            public ComplexStruct ComplexPlus(ComplexStruct complex2)
            {
                ComplexStruct complexRes;
                complexRes.re = re + complex2.re;
                complexRes.im = im + complex2.im;
                return complexRes;
            }

            public ComplexStruct ComplexSubtraction(ComplexStruct complex2)
            {
                ComplexStruct complexRes;
                complexRes.re = re - complex2.re;
                complexRes.im = im - complex2.im;
                return complexRes;
            }


        }

    }

    public class ComplexClass
    {
        private double re;

        public double Re
        {
            get { return re; }
            set { re = value; }
        }

        private double im;

        public double Im
        {
            get { return im; }
            set { im = value; }
        }

        
        public ComplexClass Subtraction(ComplexClass x)
        {
            ComplexClass complexRes = new ComplexClass();
            complexRes.re = re - x.re;
            complexRes.im = im - x.im;
            return complexRes;
        }

        public static void SubtractionOut(ComplexClass x, ComplexClass y)
        {
            ComplexClass complexRes = new ComplexClass();
            complexRes = x.Subtraction(y);
            Helpers.OutLine($"{x.re} + {x.im}i - ({y.re} + {y.im}i) = {complexRes.re} + {complexRes.im}i");
        }

        public ComplexClass Multi(ComplexClass x)
        {
            ComplexClass complexRes = new ComplexClass();
            complexRes.re = re * x.re;
            complexRes.im = im * x.im;
            return complexRes;
        }
        public static void MultiOut(ComplexClass x, ComplexClass y)
        {
            ComplexClass complexRes = new ComplexClass();
            complexRes = x.Multi(y);
            Helpers.OutLine($"({x.re} + {x.im}i) * ({y.re} + {y.im}i) = {complexRes.re} + {complexRes.im}i");
        }

        public override string ToString()
        {
            return $"{re} + {im}i";
        }
    }
}
