using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = string.Empty;
            string reversedWord = string.Empty;
            while (true)
            {
                word = Console.ReadLine();

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
    }
}
