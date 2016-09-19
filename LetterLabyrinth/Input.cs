using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterLabyrinth
{
    class Input : IInput
    {
        public Direction GetNextDirection()
        {
            var key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.RightArrow: return Direction.Right;
                case ConsoleKey.DownArrow: return Direction.Down;
                case ConsoleKey.LeftArrow: return Direction.Left;
                case ConsoleKey.UpArrow: return Direction.Up;
                default: return Direction.Down;
            }
        }
    }
}
