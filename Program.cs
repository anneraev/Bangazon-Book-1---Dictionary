using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few word
            Dictionary<string, string> excitedWord = new Dictionary<string, string>() {
                // Add each of the 4 bits of data about the word to the Dictionary
                {"word", "excited"},
                {"definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness"},
                {"part of speech", "adjective"},
                {"example sentence", "I am excited to learn C#!"}
            };
            dictionaryOfWords.Add(excitedWord);

            // Add Dictionary to your `dictionaryOfWords` list
            Dictionary<string, string> otherWord = new Dictionary<string, string>(){
                {"word", "other"},
                {"definition", "a different word"},
                {"part of speech", "who cares?"},
                {"example sentence", "I want to do something other than this."}
            };
            dictionaryOfWords.Add(otherWord);

            // create another Dictionary and add that to the list
            Dictionary<string, string> thisWord = new Dictionary<string, string>(){
                {"word", "this"},
                {"definition", "this"},
                {"part of speech", "this part"},
                {"example sentence", "This is the this that this is."}
            };
            dictionaryOfWords.Add(thisWord);

            /*
                Iterate your list of dictionaries and output the data

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> word in dictionaryOfWords)
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> wordData in word)
                {
                    Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                }
                Console.WriteLine("___________________");
            }
        }
    }
}
