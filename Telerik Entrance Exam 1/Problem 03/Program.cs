namespace Problem_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string apiKey = Console.ReadLine();

            char[] charArray = new char[apiKey.Length];

            for (int i = 0; i < apiKey.Length; i++)
            {
                charArray[i] = apiKey[i];
            }

            
            int sufficiency = 15;
            int lowercaseCharsCount = 0;
            string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            int uppercaseCharsCount = 0;
            string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int digitsCharsCount = 0;
            string digitsChars = "0123456789";
            int specialCharsCount = 0;
            string specialChars = "!@#$%^&*()_+-=><?";

            for (int i = 0; i < charArray.Length; i++)
            {
                char currentLetter = charArray[i];
                
                if (lowercaseChars.Contains(currentLetter))
                {
                    lowercaseCharsCount++;
                }

                if (uppercaseChars.Contains(currentLetter))
                {
                    uppercaseCharsCount++;
                }

                if (digitsChars.Contains(currentLetter))
                {
                    digitsCharsCount++;
                }

                if (specialChars.Contains(currentLetter))
                {
                    specialCharsCount++;
                }
               
            }
            if (lowercaseCharsCount >= 3)
            {
                sufficiency -= 3;
            }
            if (uppercaseCharsCount >= 3)
            {
                sufficiency -= 3;
            }
            if (digitsCharsCount >= 3)
            {
                sufficiency -= 3;
            }
            if (specialCharsCount >= 3)
            {
                sufficiency -= 3;
            }
            if (charArray.Length >= 15)
            {
                sufficiency -= 3;
            }
            Console.WriteLine(sufficiency);

            




        }
    }
}