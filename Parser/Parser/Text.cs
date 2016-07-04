using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;

namespace Parser
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

        public void InterrogativeSentences(int length)
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

        public ICollection<ISentence> DeleteAllWords(int length)
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

        
    }
}