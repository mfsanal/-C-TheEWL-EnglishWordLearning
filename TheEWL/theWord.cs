using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEWL
{
    class theWord
    {
        private string Word, Translated, Type, File;

        public theWord(string xWord,string xTranslated,string xType,string xFile)
        {
            Word = xWord; Translated = xTranslated; Type = xType; File = xFile;
        }

        public string getWord()
        {
            return Word;
        }
        public string getTranslated()
        {
            return Translated;
        }
        public string getType()
        {
            return Type;
        }
        public string getFile()
        {
            return File;
        }
        
    }
}
