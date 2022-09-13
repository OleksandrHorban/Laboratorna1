using System;

namespace CsharpLaba1._3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть першу змінну!");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть другу змінну!");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть третю змінну!");
            double h = double.Parse(Console.ReadLine());
            double area = ((a + b) / 2.0)*h;
            Console.WriteLine(area);
        }
    }
}
