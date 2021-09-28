using System;

namespace alphabet
{
    class VowelConsonant
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            String alphabet = Console.ReadLine();
            if (alphabet == "a" || alphabet == "e" || alphabet == "i" || alphabet == "o" || alphabet == "u")
                Console.WriteLine("Alphabet is Vowel");
            else
                Console.WriteLine("Alphabet is Consonant");
        }
    }
}
