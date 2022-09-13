using System;

namespace CsharpLaba3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            int num1, num2, num3;
            Console.Write("Знаходження найбільшого числа з трьох:\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");
            Console.Write("Введіть 1 число :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть 2 число :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть 3 число :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write(num1);
                }
                else
                {
                    Console.Write(num3);
                }
            }
            else if (num2 > num3)
                Console.Write(num2);
            else
                Console.Write(num3);
        }
    }
    }
