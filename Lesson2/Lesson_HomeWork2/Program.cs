using System.Globalization;
using static System.Array;
using static System.Console;
using static System.Convert;
using static System.String;
namespace Lesson_HomeWork2{
    internal class Program
    {
        static public Random random = new Random();


        static void Main(string[] args)
        {

            OutputEncoding = System.Text.Encoding.UTF8;
            InputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.Write("Введіть вираз (або 'стоп'): ");
                string input = Console.ReadLine() ?? "";

                if (input.Trim().ToLower() == "стоп")
                {
                    break;
                }

                if (TryCalculate(input, out long result))
                {
                    Console.WriteLine($"Результат: {result}\n");
                }
                else
                {
                    Console.WriteLine("Помилка: приклад правильного виразу 12 + 5 - 3\n");
                }
            }
        }

        static bool TryCalculate(string expression, out long result)
        {
            result = 0;

            string clean = expression.Replace(" ", "").Replace("-", "+-");

            if (clean.StartsWith("+"))
            {
                clean = clean.Substring(1); // вираз починався з мінуса
            }

            string[] parts = clean.Split('+');

            foreach (string part in parts)
            {
                if (!int.TryParse(part, out int number))
                {
                    return false;
                }
                result += number;
            }

            return true;
        }
    }
}



