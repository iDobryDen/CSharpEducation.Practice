namespace Task5b;

class Program
{
    static void Main(string[] args)
    {
        double FirstLeg = 3.0;
        double Hypotenuse = 5.0;
        
        double SecondLeg = Math.Sqrt(Hypotenuse * Hypotenuse - FirstLeg * FirstLeg);

        Console.WriteLine("Второй катет равен " + SecondLeg);
    }
}

