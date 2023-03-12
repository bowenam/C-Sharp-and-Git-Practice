using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    class Program
    {
        public static string myfunc(double x, double y)
        {
            number first = new();
            number second = new();

            first.val = y;
            second.val = x;

            return $"Before: x = {x}, y = {y}; After: x = {first.val}, y = {second.val}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(myfunc(8, 30));
            Console.WriteLine(myfunc(2, 8));

            //Car andrew = new("Andrew", "Nissan", "Altima", "maroon", 2010);
            //Console.WriteLine($"My car is a {andrew.year} {andrew.make} {andrew.model}. Its color is {andrew.color}!");
            //Console.WriteLine($"When {andrew.owner}'s {andrew.make} {andrew.model} honks, it says:");
            //andrew.honk();
        }
    }
}