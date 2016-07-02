using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class SentencePunctuation : ISentenceComponent
    {
        public SentencePunctuation(string component)
        {
            Component = component;
        }

        public string Component { get; private set; }
    }
}
