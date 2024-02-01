namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите первую фразу");
        string FirstPhrase = Console.ReadLine();
        Console.WriteLine("введите вторую фразу");
        string SecondPhrase = Console.ReadLine();
        Console.WriteLine("Ваша фраза: " + FirstPhrase + " " + SecondPhrase + "!");
    }
}

