using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Model
{
    public class SentenceSpacing : ISentenceComponent
    {
        public SentenceSpacing()
        {
            Component = " ";
        }

        public string Component { get; private set; }
    }
}
