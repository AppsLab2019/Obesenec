using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Obesenec.Model
{
    class WordSource
    {
        private static readonly List<Word> words = new List<Word>()
        {
            new Word("auto"),
            new Word("okno"),
            new Word("svet"),
            new Word("voda"),
            new Word("kryt"),
            new Word("pes"),
            new Word("automobil"),
        };

        public static Word GetRandomWord()
        {
            Random rnd = new Random();
            int index = rnd.Next(words.Count);
            return words[index];
        }

    }
}
