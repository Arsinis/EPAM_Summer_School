using System.Collections.Generic;
using Parser.Parsers;

namespace Parser.Model
{
    public interface IText 
    {
        ICollection<ISentence> SentencesCollection { get; }

        void OutText();

        void GetWordsFromInterrogativeSentences(int length);

        ICollection<ISentence> RemoveWordsStartWithConsonant(int length);

        ICollection<ISentence> DuplicateCollection();

        ICollection<ISentence> ReplaceWordWithString(string str, int number, Parsing parser, int length);

        ICollection<ISentence> SortingCollection();

        SortedDictionary<string, List<int>> Concordance(int pageCount);
    }
}