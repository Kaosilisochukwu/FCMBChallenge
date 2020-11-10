using System;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var challenge = new Challenge();
            var sentence = "The quick brown fox jumps over the lazy dog";
            var vowelCount = challenge.NumberOfVowels(sentence);
            Console.WriteLine($"The Number of vowels in the sentence  \"{ sentence.ToUpper()}\" is {vowelCount} ");
        }
    }
}
