using System;

namespace CsharpLaba1._17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            int i, f = 1, num;

            Console.Write("\n\n");
            Console.Write("Програма для знаходження факторіала числа:\n");
            Console.Write("--------------------------------------------");
            Console.Write("\n");

            Console.Write("Введіть число : ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 1)
            {

                for (i = 2; i <= num; i++)
                    f = f * i;

                Console.Write("Факторіал з {0} це: {1}\n", num, f);
            }
            else
            {
                Console.Write("Ви ввели некоректне число!");
            }
        }
    }
}
