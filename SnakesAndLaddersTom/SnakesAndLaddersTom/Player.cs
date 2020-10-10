using System;

namespace SnakesAndLaddersTom
{ 
    public class Player
    {
        public int position { get; set; }
        public bool isWinner { get; set; }
        private iDice _dice { get; }

        public Player(iDice dice)
        {
            _dice = dice;
            position = 1;

            isWinner = false;
        }

        public void Move()
        {
            var diceroll = _dice.Roll();
            Console.WriteLine($"{diceroll} was rolled.");
            var newPosition = position + diceroll;
            if (newPosition < 100)
            {
                position = newPosition;                                
            }
            if (newPosition == 100)
            {
                position = newPosition;
                isWinner = true;
            }
        }
     }
}