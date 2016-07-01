using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser
{
    public class Sentence :ISentence
    {
        private ICollection<IWord> _wordsCollection;

        public ICollection<IWord> WordsCollection
        {
            get
            {
                return _wordsCollection;
            }
            set { this._wordsCollection = value; }
        }

        public Sentence(ICollection<IWord> sourceCollection)
        {
            WordsCollection = sourceCollection;
        }
    }
}