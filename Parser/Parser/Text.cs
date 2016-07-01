using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser
{
    public class Text : IText
    {
        private ICollection<ISentence> _sentencesCollection;

        public ICollection<ISentence> SentencesCollection
        {
            get 
            {
                return _sentencesCollection;
            }
            set { this._sentencesCollection = value; }
        }

        public Text(ICollection<ISentence> sourceCollection)
        {
            SentencesCollection = sourceCollection;
            
        } 
    }
}