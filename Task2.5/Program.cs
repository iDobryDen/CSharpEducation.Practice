namespace Task2._5;

class Program
{
    static void Main(string[] args)
    {
        //a, c
        int height = 4; // Задаем высоту треугольника
        
        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("&");
            }
            Console.WriteLine();
        }

        //b

    }

}


