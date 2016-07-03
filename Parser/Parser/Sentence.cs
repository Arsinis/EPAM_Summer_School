using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser
{
    public class Sentence :ISentence
    {
        private ICollection<ISentenceComponent> _componentsCollection;

        public ICollection<ISentenceComponent> ComponentsCollection
        {
            get
            {
                return _componentsCollection;
            }
            set { this._componentsCollection = value; }
        }

        public Sentence(ICollection<ISentenceComponent> sourceCollection)
        {
            ComponentsCollection = sourceCollection;
        }

        public string CurrentSentence { get; private set; }
    }
}