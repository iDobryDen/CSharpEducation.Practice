namespace Task2._4;

class Program
{
    static void Main(string[] args)
    {
        /*
        //a
        for ( int i = 0; i < 10; i++)
        Console.WriteLine(i);

        //b
        int z5 = 1;
        while (z5 < 12)
        {
         Console.WriteLine(z5++);
        }

        //c
        int num = 8;
        do
        {
            Console.WriteLine(num--);
        }
        while (num >= 0);

        //d
        for (int i = 10; i > 0; i--)
            Console.WriteLine(i);

        //e
        int z6 = 12;
        while (z6 >= 1)
        {
            Console.WriteLine(z6--);
        }

        //f
        int num1 = 0;
        do
        {
            Console.WriteLine(num1++);
        }
        while (num1 <= 6);
        
        //g
        Console.WriteLine("Введите количество слов, которое хотите ввести:");
        string a = Console.ReadLine();
        int a1 = int.Parse(a);
        string[] words = new string[a1];
        for (int word = 0; word < a1; word++)
        {
            Console.WriteLine("Введите слово:");
            words[word] = Console.ReadLine();
        }
        Console.WriteLine("Вы ввели фразу:");
        string phrase = string.Join(" ", words);
        Console.WriteLine(phrase);
      
        //g var2
        Console.WriteLine("Введите количество слов, которое хотите ввести:");
        string a = Console.ReadLine();
        int a1 = int.Parse(a);
        string phrase = "";
        for (int i = 0; i < a1; i++)
        {
            Console.WriteLine("Введите слово:");
            string word = Console.ReadLine();

            phrase += word + " ";
        }
        Console.WriteLine("Вы ввели фразу: " + phrase);

        //h
        Console.WriteLine("Введите количество слов, которое хотите ввести:");
        string a = Console.ReadLine();
        int a1 = int.Parse(a);
        string phrase = "";
        int i = 0;
        while (i < a1)
        {
            Console.WriteLine("Введите слово:");
            string word = Console.ReadLine();
            phrase += word + " ";
            i++;
        }
        Console.WriteLine("Вы ввели фразу: " + phrase);
        */

        //i
        Console.WriteLine("Введите количество слов: ");
        string a = Console.ReadLine();
        int a1 = int.Parse(a);
        string phrase = "";
        int i = 0;
        do
        {
            Console.WriteLine("Введите слово:");
            string word = Console.ReadLine();
            phrase += word + " ";
            i++;
        }
        while (i < a1);
        Console.WriteLine("Вы ввели фразу: " + phrase);
    }
}

