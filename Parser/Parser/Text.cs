using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser
{
    public class Text : IText
    {

        public IEnumerable<ISentence> SentencesCollection { get; set; }

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
    }
}