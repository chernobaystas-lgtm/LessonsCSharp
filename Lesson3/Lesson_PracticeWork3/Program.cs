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
            OutputEncoding = System.Text.Encoding.UTF8;

            int[] myArray = { 1, 2, 3 };

            WriteLine("Масив до об'єднання: " + string.Join(", ", myArray));

            MergeWithSequence(ref myArray, 4, 5, 6, 7);

            WriteLine("Масив після об'єднання: " + string.Join(", ", myArray));
        }

        public static void MergeWithSequence(ref int[] baseArray, params int[] sequence)
        {
            int oldLength = baseArray.Length;

            Resize(ref baseArray, oldLength + sequence.Length);

            Copy(sequence, 0, baseArray, oldLength, sequence.Length);
        }

    }
}
