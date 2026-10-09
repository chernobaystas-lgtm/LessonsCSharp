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
            Write("Введіть рядок: ");
            string input = ReadLine() ?? "";

            string result = ProcessText(input);
            WriteLine($"Результат: {result}");



        }

        public static string ProcessText(string inputText)
        {
            string[] words = inputText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (word.Length >= 2)
                {
                    if (word[0] == word[1])
                    {
                        words[i] = word.ToUpper(); 
                    }
                }
            }

            return string.Join(" ", words);
        }
    }
}
