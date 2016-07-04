using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser
{
    public interface IWord : ISentenceComponent
    {
        bool IsStartWithconsonant();
    }
}