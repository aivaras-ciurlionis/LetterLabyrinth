using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterLabyrinth
{
    public class Player
    {
        private int _positionX;
        private int _positionY;

        public Player(int positionX, int positionY)
        {
            _positionX = positionX;
            _positionY = positionY;
        }

        public int GetPositionX()
        {
            return _positionX;
        }

        public int GetPositionY()
        {
            return _positionY;
        }

        public void Move(Direction direction)
        {
            // Asuming that constraints are already handled
            switch (direction)
            {
                case Direction.Right:
                    _positionX++;
                    break;
                case Direction.Down:
                    _positionY++;
                    break;
                case Direction.Left:
                    _positionX--;
                    break;
                case Direction.Up:
                    _positionY--;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }
    }
}
