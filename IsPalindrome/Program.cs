using System;
using System.Linq;

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = string.Empty;
            var reversedWord = string.Empty;

            while (true)
            {
                word = Console.ReadLine();
                word = RemoveWhiteSpaces(word);

                var ch = word.ToCharArray();
                Array.Reverse(ch);
                reversedWord = new string(ch);

                bool IsRotated = word.Equals(reversedWord, StringComparison.CurrentCulture);

                if (IsRotated)
                {
                    Console.WriteLine("" + word + " is a Palindrome!");
                }
                else
                {
                    Console.WriteLine("" + word + " is not a Palindrome!");
                }
            }
        }
        private static string RemoveWhiteSpaces(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
    }
}
