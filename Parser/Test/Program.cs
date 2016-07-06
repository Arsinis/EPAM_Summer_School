using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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


            Text anothertxt = parse.Parse(testing);
            /*anothertxt.SentencesCollection =
                anothertxt.SentencesCollection.OrderBy(sentence => sentence.ComponentsCollection.OfType<IWord>().Count())
                    .ToList*/
            anothertxt.SentencesCollection = anothertxt.SortingCollection();
            anothertxt.OutText();
            Console.WriteLine();


            txt.GetWordsFromInterrogativeSentences(3);
            Console.WriteLine();


            txt.SentencesCollection = txt.RemoveWordsStartWithConsonant(5);
            txt.OutText();
            Console.WriteLine();


            anothertxt.SentencesCollection = anothertxt.ReplaceWordWithString(StringToReplace,
                1, parse, 3);
            anothertxt.OutText();
            Console.WriteLine();


            SortedDictionary<string, List<int>> dic = anothertxt.Concordance(2);
            foreach (var d in dic)
            {
                Console.Write(d.Key + "      "+d.Value[0]+":");
                for (int i = 1; i < d.Value.Count(); i++)
                {
                    Console.Write(d.Value[i]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
