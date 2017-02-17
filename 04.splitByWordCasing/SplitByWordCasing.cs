using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.splitByWordCasing
{
    public class SplitByWordCasing
    {
        public static void Main()
        {
            var initialList = Console.ReadLine().
                Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var lowercaseWords = new List<string>();
            var mixedcaseWords = new List<string>();
            var uppercaseWords = new List<string>();

            foreach (var word in initialList)
            {
                int lowerCaseLetters = 0;
                int upperCaseLetters = 0;

                foreach (char item in word)
                {
                    if (char.IsLower(item))
                    {
                        lowerCaseLetters++;
                    }
                    else if (char.IsUpper(item))
                    {
                        upperCaseLetters++;
                    }
                }

                if (lowerCaseLetters==word.Length)
                {
                    lowercaseWords.Add(word);
                }
                else if (upperCaseLetters == word.Length)
                {
                    uppercaseWords.Add(word);
                }
                else
                {
                    mixedcaseWords.Add(word);
                }
            }
            
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowercaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedcaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", uppercaseWords));
        }
    }
}
