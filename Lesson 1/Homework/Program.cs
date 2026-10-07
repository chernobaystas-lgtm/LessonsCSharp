using System.Collections.Specialized;
using System.Globalization;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть перше число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть друге число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}

