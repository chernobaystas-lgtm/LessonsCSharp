
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

            Console.Write("Введите элементы массива через пробел: ");

            string[] numbersAsString1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] numbers2 = numbersAsString1.Select(int.Parse).ToArray();

            int[][] arrays = {
                numbers,
                numbers2
            };

            int[] newnumbersarray = numbers.Concat(numbers2).ToArray();

            Console.WriteLine("Объединяемый массив: " + string.Join(" ", newnumbersarray));
        }
    }
}
    
    
