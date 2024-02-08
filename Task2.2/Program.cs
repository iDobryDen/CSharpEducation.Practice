namespace Task2._2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("input integer from 1 to 5");
        string num = Console.ReadLine();
        int num2 = int.Parse(num);
        if (num2 <= 0 || num2 >= 6)
        {
            Console.WriteLine("Ваше число не соответствует условиям задачи");
        }
        else if (num2 == 5)
        {
            Console.WriteLine("5 -  Отлично");
        }
        else if (num2 == 4)
        {
            Console.WriteLine("4 -  Хорошо");
        }
        else if (num2 == 3)
        {
            Console.WriteLine("3 -  Удовлетворительно");
        }
        else if (num2 == 2)
        {
            Console.WriteLine("2 -  Неудовлетворительно");
        }
        else if (num2 == 1)
        {
            Console.WriteLine("1 -  Ужасно");
        }
    }
}

