using System;
namespace Program
{
class Program
{
    public static void Main(string[] args)
    {
        //count your coins
        Console.WriteLine("How many quarters do you have?");
        double q = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("How many dimes do you have?");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("How many nickels do you have?");
        double n = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("How many pennies do you have?");
        double p = Convert.ToDouble(Console.ReadLine());
        
        //convert to cents
        q *= 0.25;
        d *= 0.10;
        n *= 0.05;
        p *= 0.01;

        //print result
        Console.WriteLine($"You have ${q + d + n + p} dollars!");


    }
}
}