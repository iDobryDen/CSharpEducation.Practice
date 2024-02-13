namespace Task2._6;

class Program
{
    static void Main(string[] args)
    {
        //Создайте массив строк. В цикле заполните его значениями, которые вводит пользователь.
        Console.WriteLine("Введите количество слов: ");
        int amount = int.Parse(Console.ReadLine());
        string[] words= new string[amount];
        for (int i = 0; i < amount; i++)
        {
            Console.WriteLine("Введите слово c индексом: " + i);
            words[i] = Console.ReadLine();
        }

        Console.WriteLine("Вы ввели :");
        foreach(string word in words)
        {
            Console.WriteLine(word);
        }
    }
}

