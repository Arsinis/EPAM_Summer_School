using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser
{
    public interface ISentence 
    {
        ICollection<ISentenceComponent> ComponentsCollection { get; }
    }
}