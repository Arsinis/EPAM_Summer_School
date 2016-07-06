using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Concordance;
using Parser;
using Parser.Model;
using Parser.Parsers;
using Parser.Readers;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            string testing = " Hello my best friend! Are you okay? Today sunny.";
            string filename = "e:/1.txt";
            string StringToReplace = "abc def ";
            Reader read = new Reader();
            Parsing parse = new Parsing();
            Text txt = parse.Parse(read.Reading(filename));
            txt.OutText();
            Console.WriteLine();

            //Displays all sentences of a given text in ascending order of the number of words in each of them.
            Text anothertxt = parse.Parse(read.Reading(filename));
            anothertxt.SentencesCollection = anothertxt.SortingCollection();
            anothertxt.OutText();
            Console.WriteLine();

            //Find and print in all interrogative sentences of the text the words without repetition of a given length.
            txt.GetWordsFromInterrogativeSentences(3);
            Console.WriteLine();

            //Remove from the text all words of a given length, beginning with a consonant letter.
            txt.SentencesCollection = txt.RemoveWordsStartWithConsonant(5);
            txt.OutText();
            Console.WriteLine();

            //In a sentence, replace the words of a given length by the specified substring.
            anothertxt.SentencesCollection = anothertxt.ReplaceWordWithString(StringToReplace,
                1, parse, 3);
            anothertxt.OutText();
            Console.WriteLine();

            //Concordance task
            ConcordanceBuilder builder = new ConcordanceBuilder();
            ConcordanceResult concordance = new ConcordanceResult(builder.Concordance(2,txt));
            concordance.OutConcordance();
            Console.ReadKey();
        }
    }
}
