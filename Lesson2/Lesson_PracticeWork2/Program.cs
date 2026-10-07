
using Microsoft.VisualBasic;
using System.ComponentModel;
using static System.Array;
using static System.Console;
using static System.Convert;

namespace Lesson_PracticeWork2
{
    internal class Program
    {
        static public Random randoms = new Random();
        static void Main(string[] args)
        {
            OutputEncoding = System.Text.Encoding.UTF8;
            InputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введите элементы массива через пробел: ");

            string[] numbersAsString = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = numbersAsString.Select(int.Parse).ToArray();

            Console.Write("Введите число с котрим, мы будем сравнивать: ");
            int comparisonNumber = int.Parse(Console.ReadLine());

            int biggerCount = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > comparisonNumber)
                {
                    Console.WriteLine($"Элемент {numbers[i]} больше числа {comparisonNumber}");
                    
                }
                else if (numbers[i] < comparisonNumber)
                {
                    Console.WriteLine($"Элемент {numbers[i]} меньше числа {comparisonNumber}");
                    biggerCount++;
                }
                else
                {
                    Console.WriteLine($"Элемент {numbers[i]} равен числу {comparisonNumber}");
                }
            }
            ReadLine();
            Console.WriteLine($"Количество элементов, больших числа {comparisonNumber}: {biggerCount}");

        }
    }
}
