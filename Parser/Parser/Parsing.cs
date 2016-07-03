using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Parser
{
    public class Parsing
    {
        public string intext = ",:;";
        public string ending = ".!?";
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
                    if (buffer != null)
                    {
                        components.Add(new Word(buffer));
                        buffer = null;
                    }
                    components.Add(new SentencePunctuation(" "));
                }
                if (intext.Contains(sen[index]))
                {
                    components.Add(new Word(buffer));
                    buffer = null;
                    components.Add(new SentencePunctuation(sen[index].ToString()));
                }
                if (ending.Contains(sen[index]))
                {
                    components.Add(new Word(buffer));
                    components.Add(new SentenceEnding(sen[index].ToString()));
                }
            }
            return components;
        }
         public Text Parse(string text)
        {
            ICollection<ISentence> sentences = new List<ISentence>();
            string buffer = null;
            foreach (var symbol in text)
            {
                if (!ending.Contains(symbol))
                    buffer += symbol;
                else
                {
                    buffer += symbol;
                    sentences.Add(new Sentence(GetSentenceComponent(buffer)));
                    buffer = null;
                }
                    
            }
            Text txt = new Text(sentences);
             return txt;
        } 
    }
}