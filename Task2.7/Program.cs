namespace Task2._7;

class Program
{
    static void Main(string[] args)
    {
        //Создайте массив целых чисел. В цикле заполните его значениями счётчика в квадрате.
        int[] nums = new int[] { 1, 2, 4 };
        int num2 = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = nums[i] * nums[i];
            Console.WriteLine(nums[i]);
        }


        foreach (int num in nums)
        {
            Console.WriteLine(num);
        }
    }
}

