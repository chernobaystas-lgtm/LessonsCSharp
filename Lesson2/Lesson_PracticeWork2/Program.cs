
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

            Console.Write("Користувач ввів: ");
            string sourceString = Console.ReadLine();

            Console.Write("підрядок для пошуку: ");
            string searchWord = Console.ReadLine();

            int count = 0;
            int index = 0;

            while ((index = sourceString.IndexOf(searchWord, index)) != -1)
            {
                count++;
                index += searchWord.Length; 
            }

            Console.WriteLine($"результат пошуку: {count}");


        }
    }
}
    
    
