using System;

namespace Calculator
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            string phrase = "Ateo  Poco Poeta";
            int ammountOfLetters = letterCount(phrase);
            int f = 7;
            Console.WriteLine("The fibonacci of '" + f + "' is: " + Fibonacci(f));

            if (isPalindrome(phrase.ToLower()))
            {
                Console.WriteLine("The phrase '" + phrase + "' is a palindrome");
            }
            else
            {
                Console.WriteLine("The phrase '" + phrase + "' is not a palindrome");
            }
            Console.WriteLine("The ammount of letters in '" + phrase + "' is: " + ammountOfLetters);
        }
        public static int letterCount(string text)
        {
            return text.Length;
        }

        public static bool isPalindrome(string text)
        {
            int j = 0;

            for (int i = 0; i < text.Length / 2; i++)
            {
                while (text[i] == ' ')
                {
                    i++;
                }

                while (text[text.Length - j - 1] == ' ')
                {
                    j++;
                }

                if (text[i] != text[text.Length - j - 1])
                {
                    return false;
                }
                j++;
            }
            return true;
        }

        public static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
