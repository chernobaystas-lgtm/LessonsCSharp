using static System.Array;
using static System.Console;
using static System.Convert;
using static System.String;
namespace Lesson_HomeWork2{
    internal class Program
    {
        static public Random randoms = new Random();

        static public int[][] CreateRandomArray(int rows, int cols)
        {
            int[][] array = new int[rows][];
            for (int i = 0; i < rows; ++i)
            {
                array[i] = new int[cols];
                for (int j = 0; j < cols; ++j)
                {
                    array[i][j] = randoms.Next(-100, 101);
                }
            }
            return array;
        }

        static public void PrintArray(int[][] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = 0; j < array[i].Length; ++j)
                {
                    Write($"{array[i][j]}\t");
                }
                WriteLine();
            }
        }
        static void Main(string[] args)
        {

            int[][] array = CreateRandomArray(5, 5);
            PrintArray(array);


            int min = array[0][0], max = array[0][0];
            int minPos = 0, maxPos = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int pos = i * 5 + j;
                    if (array[i][j] < min) { min = array[i][j]; minPos = pos; }
                    if (array[i][j] > max) { max = array[i][j]; maxPos = pos; }
                }
            }
            Write($"Min value: {min} at position {minPos}\nMax value: {max} at position {maxPos}");

            int sumFromMinToMax = 0;
            for(int i = Math.Min(minPos, maxPos); i <= Math.Max(minPos, maxPos); i++)
            {
                int row = i / 5;
                int col = i % 5;
                sumFromMinToMax += array[row][col];
            }
            Write($"\nSum from min to max: {sumFromMinToMax}\n");
        }
    }
}
       
    

