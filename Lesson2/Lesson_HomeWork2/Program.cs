using System.Globalization;
using System.Text;
using static System.Array;
using static System.Console;
using static System.Convert;
using static System.String;
namespace Lesson_HomeWork2
{
    internal class Program
    {
        static public Random random = new Random();


        static void Main(string[] args)
        {

            OutputEncoding = System.Text.Encoding.UTF8;
            InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введіть текст (порожній рядок - кінець вводу):");
            StringBuilder text = new StringBuilder();
            while (true)
            {
                string line = Console.ReadLine() ?? "";
                if (line == "") break;
                text.AppendLine(line);
            }

            Console.Write("Неприпустиме слово: ");
            string forbidden = (Console.ReadLine() ?? "").Trim();

            if (forbidden == "")
            {
                Console.WriteLine("Слово не задано.");
                return;
            }

            string result = Censor(text.ToString(), forbidden, out int count);

            Console.WriteLine("\nРезультат роботи:");
            Console.WriteLine(result);
            Console.WriteLine($"Статистика: замін слова \"{forbidden}\": {count}");

            Console.ReadLine();
        }

        static string Censor(string text, string forbidden, out int count)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder word = new StringBuilder();
            int replaced = 0;

            // закрывает накопленное слово: заменяет или переносит как есть
            void Flush()
            {
                if (word.Length == 0) return;

                if (word.ToString().Equals(forbidden, StringComparison.OrdinalIgnoreCase))
                {
                    result.Append('*', word.Length);
                    replaced++;
                }
                else
                {
                    result.Append(word);
                }
                word.Clear();
            }

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    word.Append(c);
                }
                else
                {
                    Flush();
                    result.Append(c);
                }
            }
            Flush(); // последнее слово, если текст закончился буквой

            count = replaced;
            return result.ToString();

        }
    }
}



