using System.Collections.Generic;
using System.Linq;

namespace Challenge
{
    public class Challenge
    {
        public int NumberOfVowels(string sentence)
        {
            var listOfVowels = new List<string>
        {
            "a", "e", "i", "o", "u"
        };
            var numberOfVowels = sentence.Count(letter => listOfVowels.Contains(letter.ToString().ToLower()));
            return numberOfVowels;
        }
        
    }
}
