using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parser.Model;

namespace Parser.Parsers
{
    interface IParsing
    {
        ICollection<ISentenceComponent> GetSentenceComponent(string sen);

        Text Parse(string text);
    }
}
