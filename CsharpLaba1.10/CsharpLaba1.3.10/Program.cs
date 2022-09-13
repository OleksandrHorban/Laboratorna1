using System;

namespace CsharpLaba1._3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть число!");
            int n = int.Parse(Console.ReadLine());
            int lastDigit = n%(10);
            Console.WriteLine(lastDigit);
        }
    }
}
