using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concordance
{
    public class ConcordanceResult :IConcordanceResult
    {
        public SortedDictionary<string, List<int>> CurrentConcordance { get; set; }

        public ConcordanceResult(SortedDictionary<string, List<int>> sourceDictionary)
        {
            CurrentConcordance = sourceDictionary;
        }
        public void OutConcordance()
        {
            foreach (var d in CurrentConcordance)
            {
                Console.Write(d.Key + "      " + d.Value[0] + ":");
                for (int i = 1; i < d.Value.Count(); i++)
                {
                    Console.Write(d.Value[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
