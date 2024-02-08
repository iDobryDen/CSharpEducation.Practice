namespace Task2._3_;

class Program
{
    static void Main(string[] args)
    {
        int distanсe = 5000;
        int km = distanсe / 1000;

        Console.WriteLine(km);
        int km2 = 7;
        int сm = km2 * 100000;
        Console.WriteLine(сm);

        double speedmsec = 20;
        double speedkmsec = speedmsec / 1000;
        double speedkmhour = speedkmsec * 60 * 60;
        Console.WriteLine(speedkmhour);

        double C = 24;
        double F = (C * 9 / 5) + 32;
        Console.WriteLine(F);
    }
}

