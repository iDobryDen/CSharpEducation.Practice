using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task2._5;

class Program
{
    static void Main(string[] args)
    {
        //b, c
        int height2 = 5; // Задаем высоту треугольника
        char symbol1 = '*';
        char symbol2 = ' ';

        for (int i = 1; i <= height2; i++)
        {
            for (int j = 0; j < height2 - i; j++)
            {
                Console.Write(symbol2);
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write(symbol1);
            }
            Console.WriteLine();
        }
    }
}


