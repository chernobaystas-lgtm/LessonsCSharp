
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

            Console.Write("Введите элемент комбинации, который будем искать: ");
            string[] numbersAsString1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] numbers1 = numbersAsString1.Select(int.Parse).ToArray();


            int combinationCount = 0;

            for (int i = 0; i <= numbers.Length - numbers1.Length; i++)
            {
                if (numbers.Skip(i).Take(numbers1.Length).SequenceEqual(numbers1))
                {
                    combinationCount++;
                }

            }
            Console.WriteLine($"Всего найдено комбинаций в массиве: {combinationCount}");


} } }
    
    
