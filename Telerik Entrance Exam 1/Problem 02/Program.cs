using System.IO;

namespace Problem_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numberOfCollegues = int.Parse(Console.ReadLine());
            int lenghtOfVineyard = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            char[] vineyard = new char[lenghtOfVineyard];

            for (int i = 0; i < lenghtOfVineyard; i++)
            {
                vineyard[i] = input[i];
            }
            
                
            int perfectQualityGrapes = 0;
            int averageQualityGrapes = 0;

            for (int i = 0; i < lenghtOfVineyard; i++)
            {
                if (vineyard[i] == 'X')
                {
                    perfectQualityGrapes += 7;
                }
                else if (vineyard[i] == 'x')
                {
                    averageQualityGrapes += 7;
                }
            }

            int bottleOfWine = perfectQualityGrapes;
            double bottleOfRakia = averageQualityGrapes / 5;
            int glassOfWineProduced = bottleOfWine * 5;
            int glassOfRakiaProduced = (int)bottleOfRakia * 14;

            double glassOfWineConsumed = 0;
            double glassOfRakiaConsumed = 0;

            for (int j = 0; j < numberOfCollegues; j++)
            {
                glassOfRakiaConsumed++;
                glassOfWineConsumed += 2;
            }
            double bottleOfWineLeft = 0;
            double bottleOfWineNeeded = 0;
            double bottleOfRakiaLeft = 0;
            double bottleOfRakiaNeeded = 0;
            
            
            if (glassOfWineProduced >= glassOfWineConsumed)
            {
                bottleOfWineLeft = (glassOfWineProduced - glassOfWineConsumed) / 5;
                if (bottleOfWineLeft < 1)
                {
                    bottleOfWineLeft = 1;
                }
            }
            else
            {
                bottleOfWineNeeded = (glassOfWineConsumed - glassOfWineProduced) / 5;
                if (bottleOfWineNeeded < 1)
                {
                    bottleOfWineNeeded = 1;
                }
            }

            if (glassOfRakiaProduced >= glassOfRakiaConsumed)
            {
                bottleOfRakiaLeft = (glassOfRakiaProduced - glassOfRakiaConsumed) / 14;
                if (bottleOfRakiaLeft < 1)
                {
                    bottleOfRakiaLeft = 1;
                }
            }
            else
            {
                bottleOfRakiaNeeded = (glassOfRakiaConsumed - glassOfRakiaConsumed) / 14;
                if (bottleOfRakiaNeeded < 1)
                {
                    bottleOfRakiaNeeded = 1;
                }
            }

            
           if (glassOfWineProduced >= glassOfWineConsumed && glassOfRakiaProduced >= glassOfRakiaConsumed)
            {
                Console.WriteLine($"Yes! {bottleOfWineLeft:f0} bottles of wine and {bottleOfRakiaLeft:f0} bottles of rakia remaining for the next party!");
            }
           else
            {
                Console.WriteLine($"No! {bottleOfWineNeeded:f0} more bottles of wine and {bottleOfRakiaNeeded:f0} more bottles of rakia required!");
            }
            
        }
    }
}