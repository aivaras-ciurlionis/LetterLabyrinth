using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterLabyrinth
{

    public enum LanguageName
    {
        Lt = 0,
        En = 1
    }

    public class Language
    {
        private readonly LanguageName _name;
        private readonly string _dictionaryLocation;

        public Language(LanguageName name, string dictionaryLocation)
        {
            _name = name;
            _dictionaryLocation = dictionaryLocation;
        }

        public string GetDictionaryLocation()
        {
            return _dictionaryLocation;
        }

        public LanguageName GetLanguageName()
        {
            return _name;
        }
    }
}
