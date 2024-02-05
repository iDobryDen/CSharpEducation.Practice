namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        const double Pi = 3.14;
        double Radius = 5.0;
        double Square = Pi * Radius * Radius;
        Console.WriteLine("Площадь круга с радиусом " + Radius + " равна " + Square + "!");
    }
}