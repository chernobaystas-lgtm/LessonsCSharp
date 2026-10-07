
using Microsoft.VisualBasic;
using System.ComponentModel;
using static System.Array;
using static System.Console;
using static System.Convert;
using static System.String;

namespace Lesson_PracticeWork2
{
    internal class Program
    {
        static public Random randoms = new Random();
        static void Main(string[] args)
        {
            OutputEncoding = System.Text.Encoding.UTF8;
            InputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть речення: ");
            string sentence = Console.ReadLine().ToLower();

            string vowels = "аеєиіїоуюяaeiouy";
            int count = 0;

            foreach (char c in sentence)
            {
                if (vowels.Contains(c.ToString()))
                {
                    count++;
                }
            }

            Console.WriteLine($"Кількість голосних літер у реченні: {count}");


        }
    }
}
    
    
