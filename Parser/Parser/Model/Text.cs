using System;
using System.Collections.Generic;
using System.Linq;
using Parser.Parsers;

namespace Parser.Model
{
    public class Text : IText
    {
        public ICollection<ISentence> SentencesCollection { get; set; }

        public Text(ICollection<ISentence> sourceCollection)
        {
            SentencesCollection = sourceCollection;
            
        }

        public void OutText()
        {
            foreach (var sentence in SentencesCollection)
            {
                foreach (var component in sentence.ComponentsCollection)
                {
                    Console.Write(component.Component);
                }
            }
        }

        public void GetWordsFromInterrogativeSentences(int length)
        {
            foreach (var sentence in SentencesCollection)
            {
                if (sentence.ComponentsCollection.Last().Component == "?")
                {
                    HashSet<string> words = new HashSet<string>();
                    foreach (var component in sentence.ComponentsCollection)
                    {
                        if (component.Component.Length == length)
                            words.Add(component.Component);
                    }
                    foreach (var c in words)
                    {
                        Console.Write(c+" ");
                    }
                    Console.WriteLine();
                }
            }
        }

        public ICollection<ISentence> RemoveWordsStartWithConsonant(int length)
        {
            ICollection<ISentence> newsentences = new List<ISentence>();
            foreach (var sentence in SentencesCollection)
            {
                ICollection<ISentenceComponent> newcomponents = new List<ISentenceComponent>();
                foreach (var component in sentence.ComponentsCollection)
                {
                    if (component.GetType() == typeof (Word))
                    {
                        
                        if ((component as IWord).IsStartWithconsonant() && component.Component.Length == length)
                            continue;
                        newcomponents.Add(component);
                    }
                    else
                    {
                        newcomponents.Add(component);
                    }
                }
                newsentences.Add(new Sentence(newcomponents));
            }
            return newsentences;
        }

        public ICollection<ISentence> DuplicateCollection()
        {
            ICollection<ISentence> newCollection = new List<ISentence>();
            foreach (var sentence in SentencesCollection)
            {
                newCollection.Add(sentence);
            }
            return newCollection;
        } 

        public ICollection<ISentence> ReplaceWordWithString(string str, int number, Parsing parser, int length)
        {
            ICollection<ISentence> newCollection = DuplicateCollection();
            ISentence sentence = newCollection.ElementAt(number);
           
            foreach (var component in sentence.ComponentsCollection)
            {
                if (component.GetType() == typeof (Word))
                {
                    if ((component as Word).Component.Length == length)
                        (component as Word).Component = str;
                }
            }
            string buffer = null;
            foreach (var component in sentence.ComponentsCollection)
            {
                buffer += component.Component;
            }
            sentence.ComponentsCollection = parser.GetSentenceComponent(buffer);
            return newCollection;
        }

        public ICollection<ISentence> SortingCollection()
        {
            return SentencesCollection.OrderBy(sentence => sentence.ComponentsCollection.OfType<IWord>().Count())
                    .ToList();
        }
    }
}