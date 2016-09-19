using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterLabyrinth
{
    public class DictionaryReader : IDictionaryReader
    {
        private string[] _words;
        private Letter[] _letters;

        public DictionaryReader(string languageFilePath)
        {
            var lines = File.ReadAllLines(languageFilePath);
            var wordCount = int.Parse(lines.First());
            ReadAllWords(wordCount);
            var letterCount = int.Parse(lines[wordCount + 1]);
            ReadAllLetters(letterCount);
        }

        private void ReadAllWords(int count)
        {
            
        }

        private void ReadAllLetters(int count)
        {
            
        }

        public string[] GetAllWords()
        {
            throw new NotImplementedException();
        }

        public Letter[] GetAllLetters()
        {
            throw new NotImplementedException();
        }
    }
}
