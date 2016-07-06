using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parser.Model;

namespace Concordance
{
    interface IConcordanceBuilder
    {
        SortedDictionary<string, List<int>> Concordance(int pageCount, Text text);
    }
}
