using System.Collections.Generic;

namespace Parser.Model
{
    public interface ISentence 
    {
        ICollection<ISentenceComponent> ComponentsCollection { get; set; }
    }
}