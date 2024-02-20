namespace Task_2._9;

class Program
{
    static void Main(string[] args)
    {
        //Создайте двумерный массив. В циклах заполните его значениями счётчика. Выведите массив на экран.
        int[,] matrix = new int[3, 3];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.WriteLine("Введите значение массива: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Получился массив:");
        PrintArray(matrix);
    }
    public static void PrintArray(int[,] nums)
    {
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                Console.Write(nums[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}