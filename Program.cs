using System;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    class Program
    {
        public static string Elementary(double x, double y)
        {
            double addition = x + y;
            double subtraction = x - y;
            double multiplication = x * y;
            double division;
            if (y == 0)
            {
                return "You cannot divide by zero!\n\n";
            }
            else
            {
                division = x / y;
            }
            string message = $"Addition: {addition}\nSubtraction: {subtraction}\nMultiplication: {multiplication}\nDivision: {division}\n\n";
            return message;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Elementary(0, 30));
            Console.WriteLine(Elementary(2, 8));
            Console.WriteLine(Elementary(12, 1.4));
            Console.WriteLine(Elementary(7, 0));
            Console.WriteLine(Elementary(9, 2));

            //Car andrew = new("Andrew", "Nissan", "Altima", "maroon", 2010);
            //Console.WriteLine($"My car is a {andrew.year} {andrew.make} {andrew.model}. Its color is {andrew.color}!");
            //Console.WriteLine($"When {andrew.owner}'s {andrew.make} {andrew.model} honks, it says:");
            //andrew.honk();
        }
    }
}