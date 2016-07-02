using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class SentenceEnding: ISentenceComponent
    {
        public SentenceEnding(string component)
        {
            Component = component;
        }

        public string Component { get; private set; }
    }
}
