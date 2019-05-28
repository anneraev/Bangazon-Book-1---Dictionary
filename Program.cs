using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
*/
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Whatever", "The feeling of whatever.");
            wordsAndDefinitions.Add("Tautology", "Defining a concept by using the name of the concept in its definition, thus rendering that definition functionally meaningless.");

            /*
                Use square bracket lookup to get the definition two
                words and output them to the console
            */
            Console.WriteLine(wordsAndDefinitions["Whatever"]);
            Console.WriteLine(wordsAndDefinitions["Tautology"]);


            /*
                Loop over dictionary to get the following output:
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of '{word.Key}' is '{word.Value}'");
            }
        }
    }
}
