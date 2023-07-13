namespace Problem_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int totalSum = 0;
           
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0 && array[i] % 7 == 0)
                {
                    totalSum += array[i];
                }
            }
            int digitsSum = 0;

            while (totalSum > 0)
            {
                digitsSum += totalSum % 10;
                totalSum /= 10;
            }
            Console.WriteLine(digitsSum);
        }
    }
}