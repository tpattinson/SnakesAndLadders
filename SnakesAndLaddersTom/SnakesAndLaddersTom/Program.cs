using System;

namespace SnakesAndLaddersTom
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(_title);
            Console.WriteLine(_art);

            Start: Console.WriteLine("How many players are there?");
            int numberOfPlayers = Int32.Parse(Console.ReadLine());
            if (numberOfPlayers < 1)
            {
                Console.Clear();
                Console.WriteLine("Please enter a number larger than 0.");
                goto Start;
            }
            else if (numberOfPlayers > 1)
            {
                Console.WriteLine($"There are {numberOfPlayers} players.");
            }
            else Console.WriteLine($"There is {numberOfPlayers} player.");

            var gameboard = new GameBoard();
            gameboard.Setup(numberOfPlayers);
            var turnCount = 1;

            while (gameboard.IsFinished == false)
            {
                Console.WriteLine($"Start of turn {turnCount}.");
                gameboard.TakeTurn();
                Console.WriteLine($"End of turn {turnCount}.");
                Console.ReadLine();
                Console.Clear();
                turnCount++;
            }

            Restart: Console.WriteLine("Game over! " +
                "Do you want to play again? (Yes/No)");
            string playAgain = Console.ReadLine();
            
            if (playAgain.ToLowerInvariant() == "yes")
            {
                goto Start;
            }
            
            else if (playAgain.ToLowerInvariant() != "no")
                {
                    Console.Clear();
                    Console.WriteLine("Please enter yes or no.");
                    goto Restart;
                }
            else Console.WriteLine("Thanks for playing Snakes and Ladders by Player 8!");
        }

        private static string _title = @"
  ____                    _                                         _     _                   _       _                     
 / ___|   _ __     __ _  | | __   ___   ___      __ _   _ __     __| |   | |       __ _    __| |   __| |   ___   _ __   ___ 
 \___ \  | '_ \   / _` | | |/ /  / _ \ / __|    / _` | | '_ \   / _` |   | |      / _` |  / _` |  / _` |  / _ \ | '__| / __|
  ___) | | | | | | (_| | |   <  |  __/ \__ \   | (_| | | | | | | (_| |   | |___  | (_| | | (_| | | (_| | |  __/ | |    \__ \
 |____/  |_| |_|  \__,_| |_|\_\  \___| |___/    \__,_| |_| |_|  \__,_|   |_____|  \__,_|  \__,_|  \__,_|  \___| |_|    |___/
                                                                                                                            
  ____              ____    _                                    ___                                                        
 | __ )   _   _    |  _ \  | |   __ _   _   _    ___   _ __     ( _ )                                                       
 |  _ \  | | | |   | |_) | | |  / _` | | | | |  / _ \ | '__|    / _ \                                                       
 | |_) | | |_| |   |  __/  | | | (_| | | |_| | |  __/ | |      | (_) |                                                      
 |____/   \__, |   |_|     |_|  \__,_|  \__, |  \___| |_|       \___/                                                       
          |___/                         |___/                                                                               
";
        
        private static string _art = @"
                            __..._                          ╬═╬
                        ..-'      o.                        ╬═╬
                     .-'            :                       ╬═╬
                 _..'             .'__..--<                 ╬═╬
          ...--""                 '-.                        ╬═╬
      ..-'                       __.'                       ╬═╬
    .'                  ___...--'                           ╬═╬
   :        ____....---'                                    ╬═╬
  :       .'                                                ╬═╬
 :       :           _____                                  ╬═╬
 :      :    _..--'''     '''--..__                         ╬═╬
:       :  .'                      i--.                     ╬═╬
:       '.:                         :    '.                 ╬═╬
:         '--...___i---''''--..___.'      :                 ╬═╬
 :                 ''---...---''          :                 ╬═╬
  '.                                     :                  ╬═╬
    '-.                                 :                   ╬═╬
       '--...                         .'                    ╬═╬
         :   ''---....._____.....---''                      ╬═╬
         '.    '.                                           ╬═╬
           '-..  '.                                         ╬═╬
               '.  :                                        ╬═╬
                : .'                                        ╬═╬
               /  :                                         ╬═╬
             .'   :                                         ╬═╬
           .' .--'                                          ╬═╬
          '--'                                              ╬═╬
";
    }
}