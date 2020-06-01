using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Obesenec.Model
{
    class WordSource
    {
        public static string Choosen { get; set; }
        private static readonly List<Word> words = new List<Word>()
        {
            new Word("auto"),
            new Word("okno"),
            new Word("svet"),
            new Word("voda"),
            new Word("kryt"),
            new Word("pes"),
            new Word("program"),
            new Word("kvet"),
            new Word("policajt"),
            new Word("stanica"),
            new Word("automobil"),
            new Word("matematika"),
        };
        private static readonly List<Word> dopravaWords = new List<Word>()
        {
            new Word("auto"),
            new Word("policajt"),
            new Word("automobil")
        };
        private static readonly List<Word> jedloWords = new List<Word>()
        {
            new Word("jablko"),
            new Word("hotdog"),
            new Word("banan")
        };
        private static readonly List<Word> oblecenieWords = new List<Word>()
        {
            new Word("mikina"),
            new Word("sveter"),
            new Word("nohavice") 
        };

        public static Word GetRandomWord()
        {
            Random rnd = new Random();
            if (Choosen == "doprava")
            {
                int index = rnd.Next(dopravaWords.Count);
                Choosen = null;
                return dopravaWords[index];
            }
            else if (Choosen == "jedlo")
            {
                int index = rnd.Next(jedloWords.Count);
                Choosen = null;
                return jedloWords[index];

            }
            else if ( Choosen == "oblecenie")
            {
                int index = rnd.Next(oblecenieWords.Count);
                Choosen = null;
                return oblecenieWords[index];
            }
            else {
                int index = rnd.Next(words.Count);
                Choosen = null;
                return words[index];
            }
        }

    }
}
