
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

            string[] numbersAsString = { "5", "2", "8", "2", "5", "11", "4" };

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
