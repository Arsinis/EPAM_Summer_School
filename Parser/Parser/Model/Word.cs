﻿using System.Collections.Generic;
using System.Linq;

namespace Parser.Model
{
    public class Word : IWord
    {
        public static ICollection<char> Vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u','y','A', 'E', 'I', 'O', 'U','Y' };

        public Word(string component)
        {
            Component = component;
        }

        public string Component { get;  set; }
        public bool IsStartWithconsonant()
        {
            return !Vowels.Contains(Component.First());
        }
    }
}