using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterLabyrinth
{
    public class RandomGridFiller : IGridFiller
    {
        private readonly Dictionary _dictionary;

        public RandomGridFiller(Dictionary dictionary)
        {
            _dictionary = dictionary;
        }

        public Letter[][] GetLetters(int sizeX, int sizeY)
        {
            throw new NotImplementedException();
        }
    }
}
