namespace Task2._10;

class Program
{
    static void Main(string[] args)
    {
        //Напишите программу, которая проходит по массиву и находит наименьшее число.
        int[] Numbers = new int[] { 25, 2, 10, 15, 43 };

        int min = Numbers[0];
        for (int i = 1; i < Numbers.Length; i++)
        {
            if (Numbers[i] < min)
            {
                min = Numbers[i];
            }
        }
        Console.WriteLine("Наименьшее число в массиве: " + min);
    }
}

