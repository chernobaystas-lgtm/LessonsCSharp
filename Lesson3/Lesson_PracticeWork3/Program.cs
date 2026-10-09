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
            InputEncoding = System.Text.Encoding.UTF8;


            Write("Сколько строк в массиве? ");
            int rows = Convert.ToInt32(ReadLine());
            int[][] jagged = new int[rows][];
            for (int i = 0; i < jagged.Length; i++)
            {
                Write($"Сколько элементов в строке {i}? ");
                int cols = Convert.ToInt32(ReadLine());
                jagged[i] = new int[cols];
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write($"jagged[{i}][{j}]: ");
                    jagged[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            PrintArray(jagged);

            WriteLine("Массив з суммою чисел в строке массива в кінці");

            PrintArray(SumOfRowInBack(jagged));
        }

        static void PrintArray(int[][] jagged)
        {
            WriteLine();
            WriteLine("Массив:");
            if (jagged == null)
            {
                WriteLine("null");
                WriteLine("Массив не инициализирован");
                return;
            }
            for (int i = 0; i < jagged.Length; i++)
            {
                Write($"[{i}]: ");
                if (jagged[i] == null)
                {
                    WriteLine("null");
                    continue;
                }
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Write(jagged[i][j]);
                    if (j + 1 < jagged[i].Length) Write(" ");
                }
                WriteLine();
            }
        }

        static int[][] SumOfRowInBack(int[][] jagged)
        {
            if (jagged == null) return null;

            int[][] result = new int[jagged.Length][];
            for (int i = 0; i < jagged.Length; i++)
            {
                if (jagged[i] == null)
                {
                    result[i] = null;
                    continue;
                }

                int len = jagged[i].Length;
                int[] row = new int[len + 1];
                int sum = 0;
                for (int j = 0; j < len; j++)
                {
                    row[j] = jagged[i][j];
                    sum += jagged[i][j];
                }
                row[len] = sum; 
                result[i] = row;
            }

            return result;
        }
    }
}
