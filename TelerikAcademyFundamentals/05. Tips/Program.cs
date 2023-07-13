using System;

namespace _05._Tips
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            double totalSum = sum * 1.1;
            Console.WriteLine($"{totalSum:f0}");
        }
    }
}
