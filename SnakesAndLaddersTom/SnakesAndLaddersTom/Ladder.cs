using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLaddersTom
{
    public class Ladder
    {
        private int _startPosition { get; set; }
        private int _endPosition { get; set; }
        public Ladder(int incomingStartPosition, int incomingEndPosition)
        {
            _startPosition = incomingStartPosition;
            _endPosition = incomingEndPosition;
        }
        public int Move(int position)
        {
            if (position == _startPosition)
            {
                Console.WriteLine($"You landed on a ladder! You were moved to space {_endPosition}.");
                Console.WriteLine(ladderClimb);
                return _endPosition;
            }
            return position;
        }

        private string ladderClimb = @"
╬═╬
╬═╬
╬═╬
╬═╬
╬═╬
╬═╬
╬═╬
╬═╬
╬═╬
╬═╬
╬═╬
╬═╬
";
    }
}
