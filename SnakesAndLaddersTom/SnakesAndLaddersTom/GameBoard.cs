using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesAndLaddersTom
{
    public class GameBoard
    { public List<Snake> _snakeList = new List<Snake>();
      public List<Ladder> _ladderList = new List<Ladder>();
      public List<Player> _playerList = new List<Player>();
      public bool IsFinished = false;

        public void Setup(int numOfPlayers)
        {
            if (numOfPlayers <1)
            {
                throw new Exception();
            }

            SetupSnakes();
            SetupLadders();
            
            for (int startOfLoop = 0; startOfLoop < numOfPlayers; startOfLoop++)
            {
                _playerList.Add(new Player(new Dice()));
            }
        }

        public void TakeTurn()
        {
            for (int startOfLoop = 0; startOfLoop < _playerList.Count; startOfLoop++)
            {
                var player = _playerList[startOfLoop];

                Console.WriteLine($"Player {startOfLoop + 1} is on space {player.position}");

                player.Move();

                Console.WriteLine($"Player {startOfLoop + 1} is now on space {player.position}");

                IsSnake(player);

                IsLadder(player);

                if (IsWinner(player))
                {
                    Console.WriteLine($"Player {startOfLoop + 1} is the winner!");
                    break;
                }
                
                Console.ReadLine();
            }
        }
        private void SetupSnakes()
        {
            _snakeList.Add(new Snake(93, 21));
            _snakeList.Add(new Snake(60, 33));
            _snakeList.Add(new Snake(15, 8));
            _snakeList.Add(new Snake(77, 42));
            _snakeList.Add(new Snake(69, 51));
            _snakeList.Add(new Snake(41, 27));
        }

        private void SetupLadders()
        {
            _ladderList.Add(new Ladder(10, 52));
            _ladderList.Add(new Ladder(24, 46));
            _ladderList.Add(new Ladder(50, 70));
            _ladderList.Add(new Ladder(65, 97));
            _ladderList.Add(new Ladder(5, 36));
            _ladderList.Add(new Ladder(39, 62));
        }

        private bool IsWinner(Player player)
        {
            if (player.isWinner)
            {
                IsFinished = true;
                return true;
            }
            return false;
        }

        private void IsSnake(Player player)
        {
            for (int startOfLoop = 0; startOfLoop < _snakeList.Count; startOfLoop++) 
            {
                var snake = _snakeList[startOfLoop];
                player.position = snake.Move(player.position);
            }
        }

        private void IsLadder(Player player)
        {
            for (int startOfLoop = 0; startOfLoop < _ladderList.Count; startOfLoop++)
            {
                var ladder = _ladderList[startOfLoop];
                player.position = ladder.Move(player.position);
            }
        }
    }
}
