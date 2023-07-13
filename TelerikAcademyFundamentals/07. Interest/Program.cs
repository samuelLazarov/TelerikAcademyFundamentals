using System;

namespace _07._Interest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deposit = int.Parse(Console.ReadLine());
            double firstYear = deposit * 1.05;
            double secondYear = firstYear * 1.05;
            double thirdYear = secondYear * 1.05;
            Console.WriteLine($"{firstYear:f2}");
            Console.WriteLine($"{secondYear:f2}");
            Console.WriteLine($"{thirdYear:f2}");

        }
    }
}
