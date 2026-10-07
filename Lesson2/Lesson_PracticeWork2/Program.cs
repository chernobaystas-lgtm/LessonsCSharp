
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

            Console.Write("Введите предложение: ");

            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                char[] charArray = word.ToCharArray();

                Array.Reverse(charArray);

                string reversedWord = new string(charArray);

                Console.Write(reversedWord + " ");
            }

            Console.WriteLine(); 


        }
    }
}
    
    
