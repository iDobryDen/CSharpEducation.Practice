namespace Task3._7;

class Program
{
    static void Main(string[] args)
    {
        //Создайте и реализуйте метод, который будет принимать два числа и менять их значения местами.Вызовите метод в Main.

        int[] nums = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine("Введите число:");
            nums[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(nums);

        ReversNums(nums);

        Console.WriteLine("\nИнвертированный массив:");
        PrintArray(nums);
    }

    public static void ReversNums(int[] args)
    {
        Array.Reverse(args);
    }

    public static void PrintArray(int[] args)
    {
        foreach (var item in args)
        {
            Console.Write(item + " ");
        }
    }
}

