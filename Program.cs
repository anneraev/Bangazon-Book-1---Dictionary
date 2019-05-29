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

            //idioms exercise
            Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
            idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
            idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
            idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
            idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
            idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
            idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
            idioms.Add("Grain", new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
            idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
            idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
            idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

            foreach(KeyValuePair<string, List<string>> wordList in idioms){
                string sentence = "";
                foreach(String word in wordList.Value) {
                    sentence += word;
                    int index = wordList.Value.IndexOf(word);
                    int length = wordList.Value.Count;
                    length -= 1;
                    if (index != length) {
                        sentence += " ";
                    }
                }
                sentence += ".";
                Console.WriteLine(sentence);
                Console.WriteLine("___________________");
            }
        }
    }
}
