using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLaddersTom
{
    public class Dice: iDice
    {
        public int Roll()
        {
            var random = new Random();
            return random.Next(1, 6);
        }
    }
}
