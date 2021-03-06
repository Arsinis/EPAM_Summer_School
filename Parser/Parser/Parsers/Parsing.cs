﻿using System.Collections.Generic;
using System.Linq;
using Parser.Model;

namespace Parser.Parsers
{
    public class Parsing : IParsing
    {
        public string Intext = ",:;";
        public string Ending = ".!?";
       
        public bool IsLetterOrDigit(char symbol)
        {
            string PossibleSymbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890'";
            if (PossibleSymbols.Contains(symbol))
                return true;
            return false;
        }

    //Parse distinct sentence
    public ICollection<ISentenceComponent> GetSentenceComponent(string sen)
        {
            string buffer = null;
            ICollection<ISentenceComponent> components = new List<ISentenceComponent>();
            for (int index = 0; index < sen.Length; index++)
            {
                if (IsLetterOrDigit(sen[index]))
                    buffer += sen[index];
                if (sen[index] == ' ')
                {
                    if (buffer != null)
                    {
                        components.Add(new Word(buffer));
                        buffer = null;
                    }
                    components.Add(new SentenceSpacing());
                }
                if (Intext.Contains(sen[index]))
                {
                    components.Add(new Word(buffer));
                    buffer = null;
                    components.Add(new SentencePunctuation(sen[index].ToString()));
                }
                if (sen[index]=='-' && sen[index-1]==' ' && sen[index+1]==' ')
                {
                    components.Add(new SentencePunctuation(sen[index].ToString()));
                }
                if (Ending.Contains(sen[index]))
                {
                    components.Add(new Word(buffer));
                    components.Add(new SentenceEnding(sen.Substring(index)));
                }
            }
            return components;
        }
        //Parse whole text in sentences
        public Text Parse(string text)
        {
            ICollection<ISentence> sentences = new List<ISentence>();
            text = text.Replace("\n", "");
            text = text.Replace("\r", " ");
            string buffer = null;
            foreach (var symbol in text)
            {
                if (!Ending.Contains(symbol))
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