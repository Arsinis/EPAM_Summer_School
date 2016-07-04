using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Parser;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            string testing = " Hello my best friend! Are you okay? Today sunny.";
            Parsing parse = new Parsing();
            Text txt = parse.Parse(testing);
            txt.OutText();
            Console.WriteLine();
            Text anothertxt = parse.Parse(testing);
            anothertxt.SentencesCollection =
                anothertxt.SentencesCollection.OrderBy(sentence => sentence.ComponentsCollection.OfType<IWord>().Count())
                    .ToList();
            anothertxt.OutText();
            Console.WriteLine();
            txt.InterrogativeSentences(3);
            Console.WriteLine();
            txt.SentencesCollection = txt.DeleteAllWords(5);
            txt.OutText();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
