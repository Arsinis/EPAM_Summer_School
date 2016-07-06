using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parser.Model;

namespace Concordance
{
    public class ConcordanceBuilder : IConcordanceBuilder
    {
        public SortedDictionary<string, List<int>> Concordance(int pageCount,Text text )
        {
            var concordance = new SortedDictionary<string, List<int>>();
            int numberOfPage = 1;
            int currentSentence = 1;
            foreach (var sentence in text.SentencesCollection)
            {
                if (currentSentence == pageCount)
                {
                    currentSentence = 1;
                    numberOfPage++;
                }
                foreach (var component in sentence.ComponentsCollection.OfType<IWord>())
                {
                    if (concordance.ContainsKey(component.Component) &&
                        concordance[component.Component].Last() == numberOfPage)
                    {
                        concordance[component.Component][0]++;
                    }
                    if (concordance.ContainsKey(component.Component) &&
                        concordance[component.Component].Last() != numberOfPage)
                    {
                        concordance[component.Component][0]++;
                        concordance[component.Component].Add(numberOfPage);
                    }
                    if (!concordance.ContainsKey(component.Component))
                    {
                        concordance.Add(component.Component, new List<int>() { 1, numberOfPage });
                    }
                }
                currentSentence++;
            }
            return concordance;
        }
    }
}
