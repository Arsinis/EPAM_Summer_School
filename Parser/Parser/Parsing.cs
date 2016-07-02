using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Parser
{
    public class Parsing
    {
        public ICollection<ISentenceComponent> GetSentenceComponent(string sen)
        {
            string buffer = null;
            ICollection<ISentenceComponent> components = new List<ISentenceComponent>();
            for (int index = 0; index < sen.Length; index++)
            {
                if ((sen[index] >= 97 && sen[index] <= 122) || (sen[index] >= 65 && sen[index] <= 90))
                    buffer += sen[index];
                if (sen[index] == ' ')
                {
                    components.Add(new Word(buffer));
                    buffer = null;
                }
                if (Word.vowels.Contains(sen[index]))
                {
                    //do something
                }
            }
        }
       /* public Text Parse(string s)
        {
            ICollection<ISentence> sen = new List<ISentence>();
            foreach (var c in s)
            {
                if (c=='.')
                    sen.Add(new Sentence());
            }

        }  */
    }
}