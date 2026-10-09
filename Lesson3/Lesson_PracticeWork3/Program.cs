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
            int begin = ToInt32(ReadLine());
            if (int.TryParse(ReadLine(), out begin) == false)
            {
                WriteLine("Ошибка ввода. Введите целое число.");
                return;
            }
            WriteLine("Введите конец диапазона:");
            int end = ToInt32(ReadLine());
            if (int.TryParse(ReadLine(), out end) == false)
            {
                WriteLine("Ошибка ввода. Введите целое число.");
                return;
            }
            if (begin > end)
            {
                int buffer = begin;
                begin = end;
                end = buffer;
            }



            long Powsum = ProductNumbers(begin, end);
            WriteLine($"Произведение чисел от {begin} до {end} равно {Powsum}");
        }

        static long ProductNumbers(int begin, int end)
        {
            long product = 1;
            for (int i = begin; i <= end; i++)
            {
                product *= i;
            }
            return product;
        }
    }
}
