using System;

namespace _04._Bottle_Deposit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallBottles = int.Parse(Console.ReadLine());
            int bigBottles = int.Parse(Console.ReadLine());
            double totalSum = smallBottles * 0.1 + bigBottles * 0.25;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
