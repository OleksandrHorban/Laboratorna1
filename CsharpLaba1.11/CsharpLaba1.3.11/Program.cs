using System;

namespace CsharpLaba1._3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть число!");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть n-ту цифру числа справа, яку потрібно вивести!");
            int n = int.Parse(Console.ReadLine());
            int nDigit = (number/ (int)Math.Pow(10, n - 1.0))%10;
            if (nDigit <= 0)
            {
                Console.WriteLine("Ви ввели неіснуючу n-ту цифру!");
            }
            else
            {
                Console.WriteLine(nDigit);
            }
        }
    }
}
