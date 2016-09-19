using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterLabyrinth
{
    public class GameStatus
    {
        private static GameStatus _instance;
        private Language _currentLanguage;
        private int _points;
        private List<Letter> _currentWord;

        private GameStatus()
        {
            _currentWord = new List<Letter>();
            _points = 0;
        }

        public GameStatus GetInstance()
        {
            return _instance ?? (_instance = new GameStatus());
        }

        public int GetPoints()
        {
            return _points;
        }

        public int AddPoints(int points)
        {
            return _points += points;
        }

        public void AddLetter(Letter letter)
        {
            _currentWord.Add(letter);
        }

        public void ClearCurrentWord()
        {
            _currentWord.Clear();
        }

        public void SetLanguage(Language language)
        {
            _currentLanguage = language;
        }

        public override string ToString()
        {
            var currentWord = _currentWord.Aggregate("", (s, letter) => letter.GetName().ToUpper());
            var languageName = _currentLanguage.GetLanguageName().ToString().ToUpper();
            return $"Current language: {languageName} {Environment.NewLine}" +
                   $"Current word: {currentWord} {Environment.NewLine} " +
                   $"Points: {_points} {Environment.NewLine}";
        }

    }
}
