using System.Collections.Generic;

namespace Parser.Model
{
    public interface IText 
    {
        ICollection<ISentence> SentencesCollection { get; }
       
    }
}