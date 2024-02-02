using System;

namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        
        double FirstLeg = 15.0;
        double SecondLeg = 25.0;
        double Hypotenuse = Math.Sqrt(FirstLeg * FirstLeg + SecondLeg * SecondLeg);
        Console.WriteLine("Гипотенуза равна " + Hypotenuse);
    }
}
