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
            int count = ReadInt("Сколько будет матриц (1-26): ", 1, 26);
            int fillMode = ReadInt("Заполнять: 1 - вручную, 2 - случайными числами: ", 1, 2);

            double[][,] matrices = new double[count][,];
            for (int i = 0; i < count; i++)
            {
                char name = (char)('A' + i);
                Console.WriteLine($"\nМатрица {name}");
                int rows = ReadInt("  Строк: ", 1, 10);
                int cols = ReadInt("  Столбцов: ", 1, 10);
                matrices[i] = new double[rows, cols];
                FillMatrix(matrices[i], name, fillMode);
            }

            while (true)
            {
                Console.WriteLine("\n1 - Показать все матрицы");
                Console.WriteLine("2 - Умножить матрицу на число");
                Console.WriteLine("3 - Сложить две матрицы");
                Console.WriteLine("4 - Умножить две матрицы");
                Console.WriteLine("0 - Выход");
                int choice = ReadInt("Выбор: ", 0, 4);

                if (choice == 0) break;

                switch (choice)
                {
                    case 1:
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine($"\nМатрица {(char)('A' + i)}:");
                            PrintMatrix(matrices[i]);
                        }
                        break;

                    case 2:
                        {
                            int a = ReadMatrixIndex("Какую матрицу умножаем: ", count);
                            double number = ReadDouble("Число: ");
                            Console.WriteLine("\nРезультат:");
                            PrintMatrix(MultiplyByNumber(matrices[a], number));
                            break;
                        }

                    case 3:
                        {
                            int a = ReadMatrixIndex("Первая матрица: ", count);
                            int b = ReadMatrixIndex("Вторая матрица: ", count);
                            if (matrices[a].GetLength(0) != matrices[b].GetLength(0) ||
                                matrices[a].GetLength(1) != matrices[b].GetLength(1))
                            {
                                Console.WriteLine("Сложить нельзя: размеры разные.");
                                break;
                            }
                            Console.WriteLine("\nРезультат:");
                            PrintMatrix(Add(matrices[a], matrices[b]));
                            break;
                        }

                    case 4:
                        {
                            int a = ReadMatrixIndex("Первая матрица: ", count);
                            int b = ReadMatrixIndex("Вторая матрица: ", count);
                            if (matrices[a].GetLength(1) != matrices[b].GetLength(0))
                            {
                                Console.WriteLine("Умножить нельзя: столбцов у первой не равно строкам у второй.");
                                break;
                            }
                            Console.WriteLine("\nРезультат:");
                            PrintMatrix(MultiplyMatrices(matrices[a], matrices[b]));
                            break;
                        }
                }
            }
        }

        static void FillMatrix(double[,] m, char name, int mode)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (mode == 1)
                        m[i, j] = ReadDouble($"  {name}[{i},{j}]: ");
                    else
                        m[i, j] = random.Next(-10, 11);
                }
            }
        }

        static double[,] MultiplyByNumber(double[,] m, double number)
        {
            int rows = m.GetLength(0);
            int cols = m.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = m[i, j] * number;

            return result;
        }

        static double[,] Add(double[,] a, double[,] b)
        {
            int rows = a.GetLength(0);
            int cols = a.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = a[i, j] + b[i, j];

            return result;
        }

        static double[,] MultiplyMatrices(double[,] a, double[,] b)
        {
            int rows = a.GetLength(0);
            int cols = b.GetLength(1);
            int common = a.GetLength(1);
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < common; k++)
                        sum += a[i, k] * b[k, j];
                    result[i, j] = sum;
                }
            }

            return result;
        }

        static void PrintMatrix(double[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                    Console.Write($"{m[i, j],8:F2}");
                Console.WriteLine();
            }
        }

        static int ReadMatrixIndex(string prompt, int count)
        {
            while (true)
            {
                Console.Write(prompt);
                string text = (Console.ReadLine() ?? "").Trim().ToUpper();
                if (text.Length == 1 && text[0] - 'A' >= 0 && text[0] - 'A' < count)
                    return text[0] - 'A';
                Console.WriteLine($"Введи букву от A до {(char)('A' + count - 1)}");
            }
        }

        static int ReadInt(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int value) && value >= min && value <= max)
                    return value;
                Console.WriteLine($"Нужно целое число от {min} до {max}");
            }
        }

        static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string text = (Console.ReadLine() ?? "").Replace(',', '.');
                if (double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
                    return value;
                Console.WriteLine("Нужно число");
            }
        }




    }
    }

       
    

