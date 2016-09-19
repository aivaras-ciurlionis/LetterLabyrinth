using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterLabyrinth
{
    public enum Direction
    {
        Right = 0,
        Down = 1,
        Left = 2,
        Up = 3
    }

    public interface IInput
    {
        Direction GetNextDirection();
    }

}
