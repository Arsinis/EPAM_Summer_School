using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser
{
    public class Word : IWord
    {
        public static ICollection<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

        public Word(string component)
        {
            Component = component;
        }

        public string Component { get; private set; }
        public bool IsStartWithconsolant()
        {
            return !vowels.Contains(Component.First());
        }
    }
}