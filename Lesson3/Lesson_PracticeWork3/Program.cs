using System.ComponentModel;
using static System.Console;
using static System.Convert;
using static System.Array;
namespace Lesson_PracticeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = System.Text.Encoding.UTF8;
            InputEncoding = System.Text.Encoding.UTF8;

            WriteLine("Введите начало диапазона:");
            string input = ReadLine();
            if (!int.TryParse(input, out int fabonaci))
            {
                WriteLine("Ошибка ввода. Введите целое число.");
                return;
            }
            
            int Realfabonaci = ISNumberFabonaci(fabonaci);
            WriteLine($"F({fabonaci}) = {Realfabonaci}");
        }

        private static int ISNumberFabonaci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            int a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                int t = a + b;
                a = b;
                b = t;
            }
            return b;
        }
    }
}
