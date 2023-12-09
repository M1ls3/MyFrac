using Lab2_2_;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Linq;
using System.Threading.Channels;

namespace Task2_MyFrac
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInput first Frac: ");
            string[] value = Console.ReadLine().Trim().Split();
            MyFrac f_frac = new MyFrac(Convert.ToInt32(value[0]), Convert.ToInt32(value[1]));
            value = null ;

            Console.WriteLine("\nInput secound Frac: ");
            value = Console.ReadLine().Trim().Split();
            MyFrac s_frac = new MyFrac(Convert.ToInt32(value[0]), Convert.ToInt32(value[1]));

            Console.WriteLine($"\nFirst Frac: {f_frac}; Secound Frac: {s_frac}");

            Console.WriteLine($"\nThe first fraction: {MyFrac.ToStringWithIntegerPart(f_frac)}");
            Console.WriteLine($"The second fraction: {MyFrac.ToStringWithIntegerPart(s_frac)}");
            Console.WriteLine();

            Console.WriteLine($"\nThe first fraction in decimal form: {MyFrac.DoubleValue(f_frac)}");
            Console.WriteLine($"The second fraction in decimal form: {MyFrac.DoubleValue(s_frac)}");
            Console.WriteLine();

            Console.WriteLine("\nAdding:");
            Console.WriteLine(MyFrac.ToStringWithIntegerPart(f_frac + s_frac));
            Console.WriteLine();

            Console.WriteLine("\nSubtraction");
            Console.WriteLine(MyFrac.ToStringWithIntegerPart(f_frac - s_frac));
            Console.WriteLine();

            Console.WriteLine("\nMultiplication");
            Console.WriteLine(MyFrac.ToStringWithIntegerPart(f_frac * s_frac));
            Console.WriteLine();

            Console.WriteLine("\nDivision");
            Console.WriteLine(MyFrac.ToStringWithIntegerPart(f_frac / s_frac));
            Console.WriteLine();

            Console.WriteLine(MyFrac.ToStringWithIntegerPart(MyFrac.CalcSum1(4)));
            Console.WriteLine(MyFrac.ToStringWithIntegerPart(MyFrac.CalcSum2(4)));
        }
    }
} 