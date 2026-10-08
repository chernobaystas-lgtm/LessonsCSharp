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
            int[] a = new int[5];
            for (int i = 0; i < a.Length; ++i)
            {
                Write($"Введите {i + 1} элемент массива: ");
                a[i] = ToInt32(ReadLine());
            }
            double[][] B = new double[3][];
            for (int i = 0; i < B.Length; ++i)
            {
                B[i] = new double[4];
            }
            Console.WriteLine("Массив B: \n");
            for (int i = 0; i < B.Length; ++i)
            {
                for (int j = 0; j < B[i].Length; ++j)
                {
                    B[i][j] = randoms.NextDouble() * 200 - 100;
                    Console.Write($"{B[i][j],8:F2}");
                }
                Console.WriteLine();
            }


            double max = a[0];
            double min = a[0];
            double sum = 0;
            double product = 1;
            double evenSumA = 0;
            double oddColumnsSumB = 0;

            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] > max) max = a[i];
                if (a[i] < min) min = a[i];
                sum += a[i];
                product *= a[i];
                if (a[i] % 2 == 0) evenSumA += a[i];
            }

            for (int i = 0; i < B.Length; ++i)
            {
                for (int j = 0; j < B[i].Length; ++j)
                {
                    if (B[i][j] > max) max = B[i][j];
                    if (B[i][j] < min) min = B[i][j];
                    sum += B[i][j];
                    product *= B[i][j];
                    if (j % 2 == 0) oddColumnsSumB += B[i][j];
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Максимум: {max:F2}");
            Console.WriteLine($"Минимум: {min:F2}");
            Console.WriteLine($"Сумма всех элементов: {sum:F2}");
            Console.WriteLine($"Произведение всех элементов: {product:E3}");
            Console.WriteLine($"Сумма чётных элементов A: {evenSumA}");
            Console.WriteLine($"Сумма нечётных столбцов B: {oddColumnsSumB:F2}");

        }
    }
}
       
    

