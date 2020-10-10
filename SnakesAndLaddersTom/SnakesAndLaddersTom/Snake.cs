using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLaddersTom
{
    public class Snake
    {
        private int _startPosition { get; set; }
        private int _endPosition { get; set; }
        public Snake(int incomingStartPosition, int incomingEndPosition)
        {
            _startPosition = incomingStartPosition;
            _endPosition = incomingEndPosition;
        }
        public int Move(int position)
        {
            if (position == _startPosition)
            {
                Console.WriteLine(_snakeArt);
                Console.WriteLine($"You landed on a snake! You were moved to space {_endPosition}.");
                return _endPosition;
            }
            return position; 
        }
        
        private string _snakeArt = @"
             ____
            / . .\
            \  ---<
             \  /
   __________/ /
-=:___________/
";
    }
}
