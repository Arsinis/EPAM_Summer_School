using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concordance
{
    interface IConcordanceResult
    {
        SortedDictionary<string, List<int>> CurrentConcordance { get; set; }
        void OutConcordance();
    }
}
