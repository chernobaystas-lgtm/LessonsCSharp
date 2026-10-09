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
                string rawWord = words[i];

                if (rawWord.Length > 0)
                {
                    int cleanLength = rawWord.Length;
                    while (cleanLength > 0 && char.IsPunctuation(rawWord[cleanLength - 1]))
                    {
                        cleanLength--;
                    }

                    string word = rawWord.Substring(0, cleanLength);
                    string punctuation = rawWord.Substring(cleanLength);

                    if (word.Length > 0)
                    {
                        string lowerWord = word.ToLower();
                        char firstChar = lowerWord[0];

                        if (lowerWord.IndexOf(firstChar, 1) != -1)
                        {
                            words[i] = word.ToUpper() + punctuation;
                        }
                        else
                        {
                            words[i] = word + punctuation;
                        }
                    }
                    
                }
            }
            return string.Join(" ", words);
        }
    }
}
