using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterLabyrinth
{
    public class Dictionary
    {
        private Language _language;
        private string[] _words;
        private List<Letter> _letters = new List<Letter>();

        public Dictionary(Language language)
        {
            _language = language;
            var reader = new DictionaryReader(_language.GetDictionaryLocation());
            _words = reader.GetAllWords();
            _letters.AddRange(reader.GetAllLetters());
        }

        public bool WordExists(Letter[] word)
        {
            throw new NotImplementedException();
        }

        public bool AnyWordBeginsWith(Letter[] fragment)
        {
            throw new NotImplementedException();
        }

        public string GetAnyWordOfLength(int length)
        {
            throw new NotImplementedException();
        }

        public Language GetLanguage()
        {
            return _language;
        }

        public Letter[] GetLettersOfWord(string word)
        {
            throw new NotImplementedException();
        }

        private string StringFromLetters(Letter[] letters)
        {
            throw new NotImplementedException();
        }
    }
}
