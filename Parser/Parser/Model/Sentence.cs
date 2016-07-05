using System.Collections.Generic;

namespace Parser.Model
{
    public class Sentence :ISentence
    {
        public ICollection<ISentenceComponent> ComponentsCollection { get; set; }

        public Sentence(ICollection<ISentenceComponent> sourceCollection)
        {
            ComponentsCollection = sourceCollection;
        }

    }
}