using System;

namespace CsharpLaba1._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Будь ласка введіть 3 числа:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if ((a < 0 && b > 0 && c > 0) || (b < 0 && a > 0 && c > 0) || (c < 0 && a > 0 && b > 0) || (a < 0 && b < 0 && c < 0))
            {
                Console.WriteLine("Negative");
            }
            else if ((a < 0 && b < 0 && c > 0) || (a < 0 && c < 0 && b > 0) || (b < 0 && c < 0 && a > 0) || (a > 0 && b > 0 && c > 0))
            {
                Console.WriteLine("Positive");
            }
            else if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Null");
            }
        }
    }
}
