using System;

namespace CsharpLaba1._3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть першу змінну!");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть другу змінну!");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть третю змінну!");
            int c = int.Parse(Console.ReadLine());
            double average = (a + b + c) / 3.0;
            Console.WriteLine(average);
        }
    }
}
