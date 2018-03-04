using System;

namespace PalindromeDemo
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Please enter a word to check if it is a palindrome.");
            String phrase = Console.ReadLine();

            if (IsAPalindrome(phrase))
                Console.WriteLine("It is a palindrome!");
            else
                Console.WriteLine("It is not a palindrome!");

            Console.ReadLine();

        }
        
        public static bool IsAPalindrome(String phrase) { 
        
            // get the size of the phrase
            int length = phrase.Length;
            
            // count or cursor. Initilize as 0 
            int c = 0;

            while (c <= length / 2)
            {
                // start at 0 and compare to value on last index,
                // increment by 1 from both sides and compare values
                if (phrase[c] != phrase[phrase.Length - 1 - c])
                    return false;
                    c++;
            }
            return true;

        }   
    }
}
