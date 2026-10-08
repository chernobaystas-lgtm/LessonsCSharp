using static System.Array;
using static System.Console;
using static System.Convert;
using static System.String;
namespace Lesson_HomeWork2{
    internal class Program
    {
        static public Random randoms = new Random();


        static void Main(string[] args)
        {
            Console.Write("Введіть рядок: ");
            string text = Console.ReadLine() ?? "";

            int shift = ReadInt("Введіть зсув: ");

            string encrypted = Encrypt(text, shift);
            Console.WriteLine($"Зашифровано: {encrypted}");
            Console.WriteLine($"Розшифровано: {Encrypt(encrypted, -shift)}");

            Console.ReadLine();
        }

        static string Encrypt(string text, int shift)
        {
            string[] alphabets =
            {
                "abcdefghijklmnopqrstuvwxyz",
                "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя"
            };

            char[] result = text.ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                foreach (string alphabet in alphabets)
                {
                    int index = alphabet.IndexOf(char.ToLower(result[i]));
                    if (index == -1) continue; 

                    int n = alphabet.Length;
                    int newIndex = ((index + shift) % n + n) % n;
                    char letter = alphabet[newIndex];

                    result[i] = char.IsUpper(result[i]) ? char.ToUpper(letter) : letter;
                    break;
                }
            }

            return new string(result);
        }





        }
    }
}
       
    

