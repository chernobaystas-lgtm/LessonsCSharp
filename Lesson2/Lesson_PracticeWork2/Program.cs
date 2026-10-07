
using System.ComponentModel;
using static System.Console;
using static System.Convert;
using static System.Array;

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
            
            string[] numbersAsString = Console.ReadLine().Split(' ');

            int[] numbers = numbersAsString.Select(int.Parse).ToArray();

            int evenCount = numbers.Where(n => n % 2 == 0).Count();

            int oddCount = numbers.Where(n => n % 2 != 0).Count();

            int uniqueCount = numbers.Distinct().Count();

            Console.WriteLine($"Четных: {evenCount}");    
            Console.WriteLine($"Нечетных: {oddCount}");   
            Console.WriteLine($"Уникальных: {uniqueCount}");

        }
    }
}
