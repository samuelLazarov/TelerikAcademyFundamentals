using System;

namespace _06._Sum_Positive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = n * (n + 1) / 2;
            Console.WriteLine(sum);
        }
    }
}
