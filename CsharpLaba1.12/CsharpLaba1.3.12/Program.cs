using System;

namespace CsharpLaba1._3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть число");
            int n = int.Parse(Console.ReadLine());
            bool result;
            if (n > 20 && n%2==1)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            Console.WriteLine(result);


        }
    }
}
