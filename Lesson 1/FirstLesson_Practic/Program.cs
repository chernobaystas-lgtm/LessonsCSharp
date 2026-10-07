using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstLesson_Practic
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.Write("Довжина лінії: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Символ-заповнювач: ");
            char symbol = Console.ReadLine()?[0] ?? '+';

            Console.Write("Напрямок (1 - горизонтальна, 2 - вертикальна): ");
            int direction = Convert.ToInt32(Console.ReadLine());

            if (direction == 1)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine(); 
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(symbol);
                }
            }
        }
    }
}
