using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LetterLabyrinth
{
    public class LetterGrid
    {
        private List<List<Letter>> _letters = new List<List<Letter>>();
        private readonly int _sizeX;
        private readonly int _sizeY;

        public LetterGrid(int sizeX, int sizeY, IGridFiller filler)
        {
            var letters = filler.GetLetters(sizeX, sizeY);
            _letters.AddRange(letters.Select(l => l.ToList()));
            _sizeX = sizeX;
            _sizeY = sizeY;
        }

        public Letter ConsumeLetterAt(int x, int y)
        {
            var consumedLetter = _letters[x][y];
            _letters[x][y] = Letter.Empty();
            return consumedLetter;
        }

        public override string ToString()
        {
            throw  new NotImplementedException();
        }

    }
}
