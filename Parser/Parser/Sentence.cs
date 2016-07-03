using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser
{
    public class Sentence :ISentence
    {
        public ICollection<ISentenceComponent> ComponentsCollection { get; }

        public Sentence(ICollection<ISentenceComponent> sourceCollection)
        {
            ComponentsCollection = sourceCollection;
        }

    }
}