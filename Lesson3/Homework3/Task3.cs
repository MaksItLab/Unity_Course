using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryHelp;

namespace Homework3
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            bool func = true;
            int action;
            string choice;

            Fraction fraction1 = new Fraction();
            Fraction fraction2 = new Fraction();

            try
            {
                Helpers.OutLine("Enter the numerator of the first fraction");
                fraction1.Numerator = int.Parse(Helpers.Enter());
                Helpers.OutLine("Enter the denominator of the first fraction");
                fraction1.Denominator = int.Parse(Helpers.Enter());
                Helpers.OutLine("Enter the numerator of the second fraction");
                fraction2.Numerator = int.Parse(Helpers.Enter());
                Helpers.OutLine("Enter the denominator of the second fraction");
                fraction2.Denominator = int.Parse(Helpers.Enter());
            }
            catch (ArgumentException)
            {
                Helpers.OutLine("Not correct data");
                return;
            }
            


            while (func)
            {
                Helpers.OutLine("1. Plus\n" +
                                "2. Subtraction\n" +
                                "3. Multi\n" +
                                "4. Division\n");
                action = int.Parse(Helpers.Enter());
                switch (action)
                {
                    case 1:
                        Fraction.Plus(fraction1, fraction2);
                        break;

                    case 2:
                        Fraction.Subtraction(fraction1, fraction2);
                        break;

                    case 3:
                        Fraction.Multi(fraction1, fraction2);
                        break;

                    case 4:
                        Fraction.Division(fraction1, fraction2);
                        break;

                    default:
                        Helpers.OutLine("Enter correct data");
                        break;

                }

                Helpers.OutLine("Do you want to continue?");
                choice = Helpers.Enter();
                if (choice == "no" || choice == "нет")
                {
                    func = false;
                }
            }
        }
    }

    class Fraction
    {
        public static bool numeratorNull = false;
        private int numerator;
        public int Numerator
        {
            get { return numerator; }
            set 
            {
                if (value == 0) numeratorNull = true;
                numerator = value; 
            }
        }

        private int denominator;
        public int Denominator
        {
            get { return denominator; }
            set 
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator can not be 0");
                }
                else denominator = value; 
            }
        }

        private double dec;
        public double Dec
        {
            get { return (double)Numerator / Denominator; }

        }
        public Fraction()
        {

        }
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator can not be 0");
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static Fraction Decimal(Fraction a)
        {
            int n = a.numerator;
            int d = a.denominator;
            n = Math.Abs(n);
            d = Math.Abs(d);
            while (d != 0 && n != 0)
            {
                if (n % d > 0)
                {
                    var temp = n;
                    n = d;
                    d = temp % d;
                }
                else break;
            }
            if (d != 0 && n != 0)
            {
                a.Numerator /= d;
                a.Denominator /= d;
                return a;
            }
            return a;
        }

        public static void Plus(Fraction a, Fraction b)
        {
            if (!numeratorNull)
            {
                Fraction fractionRes = new Fraction();
                a = Decimal(a);
                b = Decimal(b);
                fractionRes.Denominator = a.Denominator * b.Denominator;
                fractionRes.Numerator = fractionRes.Denominator / a.Denominator * a.Numerator + fractionRes.Denominator / b.Denominator * b.Numerator;
                fractionRes = Decimal(fractionRes);
                Helpers.OutLine($"{a} + {b} = {fractionRes}");
                Helpers.OutLine($"{a.Dec:F3} + {b.Dec:F3} = {fractionRes.Dec:F3}");
            }
            else
            {
                if (a.Numerator == 0)
                {
                    b = Decimal(b);
                    Helpers.OutLine($"0 + {b} = {b}");
                    Helpers.OutLine($"0 + {b.Dec:F3} = {b.Dec:F3}");
                }
                else if (b.Numerator == 0)
                {
                    a = Decimal(a);
                    Helpers.OutLine($"{a} + 0 = {a}");
                    Helpers.OutLine($"{a.Dec:F3} + 0 = {a.Dec:F3}");
                }
                
            }
            
        }
        public static void Subtraction(Fraction a, Fraction b)
        {
            if (!numeratorNull)
            {
                Fraction fractionRes = new Fraction();
                a = Decimal(a);
                b = Decimal(b);
                fractionRes.Denominator = a.Denominator * b.Denominator;
                fractionRes.Numerator = fractionRes.Denominator / a.Denominator * a.Numerator - fractionRes.Denominator / b.Denominator * b.Numerator;
                fractionRes = Decimal(fractionRes);
                Helpers.OutLine($"{a} - {b} = {fractionRes}");
                Helpers.OutLine($"{a.Dec:F3} - {b.Dec:F3} = {fractionRes.Dec:F3}");
            }
            else
            {
                if (a.Numerator == 0)
                {
                    b = Decimal(b);
                    Helpers.OutLine($"0 - {b} = -{b}");
                    Helpers.OutLine($"0 - {b.Dec:F3} = -{b.Dec:F3}");
                }
                else if (b.Numerator == 0)
                {
                    a = Decimal(a);
                    Helpers.OutLine($"{a} - 0 = {a}");
                    Helpers.OutLine($"{a.Dec:F3} - 0 = {a.Dec:F3}");
                }
            }
            
        }

        public static void Multi(Fraction a, Fraction b)
        {
            if (!numeratorNull)
            {
                Fraction fractionRes = new Fraction();
                a = Decimal(a);
                b = Decimal(b);
                fractionRes.Denominator = a.Denominator * b.Denominator;
                fractionRes.Numerator = a.Numerator * b.Numerator;
                fractionRes = Decimal(fractionRes);
                Helpers.OutLine($"{a} * {b} = {fractionRes}");
                Helpers.OutLine($"{a.Dec:F3} * {b.Dec:F3} = {fractionRes.Dec:F3}");
            }
            else
            {
                if (a.Numerator == 0)
                {
                    b = Decimal(b);
                    Helpers.OutLine($"0 * {b} = 0");
                    Helpers.OutLine($"0 * {b.Dec:F3} = 0");
                }
                else if (b.Numerator == 0)
                {
                    a = Decimal(a);
                    Helpers.OutLine($"{a} * 0 = 0");
                    Helpers.OutLine($"{a.Dec:F3} * 0 = 0");
                }
            }
            
        }

        public static void Division(Fraction a, Fraction b)
        {
            if (!numeratorNull)
            {
                Fraction fractionRes = new Fraction();
                a = Decimal(a);
                b = Decimal(b);
                fractionRes.Numerator = a.Numerator * b.Denominator;
                fractionRes.Denominator = a.Denominator * b.Numerator;
                fractionRes = Decimal(fractionRes);
                Helpers.OutLine($"{a} / {b} = {fractionRes}");
                Helpers.OutLine($"{a.Dec:F3} / {b.Dec:F3} = {fractionRes.Dec:F3}");
            }
            else
            {
                if (a.Numerator == 0)
                {
                    b = Decimal(b);
                    Helpers.OutLine($"0 / {b} = 0");
                    Helpers.OutLine($"0 / {b.Dec:F3} = 0");
                }
                else if (b.Numerator == 0)
                {
                    Helpers.OutLine("Division by 0");
                }
            }
        }

        public override string ToString()
        {
            return $"{Numerator}\\{Denominator}";
        }
    }
}
