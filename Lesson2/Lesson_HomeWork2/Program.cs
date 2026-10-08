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
            Write("Введіть предложение: ");
            char[] input = ReadLine().ToCharArray();
            bool IsUpper = true;
            char fullStop = '.';
            char questionMark = '?';
            char exclamationMark = '!';


            for (int i = 0; i < input.Length; i++)
            {
                if (IsUpper)
                {
                    input[i] = char.ToUpper(input[i]);
                    IsUpper = false;
                }
                else if (!char.IsLetter(input[i]))
                {
                    input[i] = char.ToUpper(input[i + 1]);
                    IsUpper = false;
                }
                else
                {
                    input[i] = char.ToLower(input[i]);
                }
            }
            WriteLine(new string(input));
        }


    }
}



