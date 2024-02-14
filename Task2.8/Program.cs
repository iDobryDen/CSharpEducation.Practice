namespace Task2._8;

class Program
{
    static void Main(string[] args)
    {
        //Создайте массив массивов. Размер каждого внутреннего массива должен быть на 1 больше, чем предыдущий. Первый массив должен быть размера 1.
        Console.WriteLine("Введите желаемое количество подмассивов: ");
        int a = int.Parse(Console.ReadLine());
        int[][] matrix = new int[a][];

        

        for (int i = 0; i < a; i++)
        {
            matrix[i] = new int[i + 1];
            for (int j = 0; j < matrix[i].Length; j++)
            {
                //matrix[i][j] = new Random().Next();
                Console.WriteLine("Введите значение:");
                matrix[i][j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < matrix.Length; i++)
            for (int j = 0; j < matrix[i].Length; j++)
                Console.WriteLine("Значения в массиве: " + matrix[i][j]);
    }
}

