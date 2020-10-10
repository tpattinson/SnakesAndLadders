using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many players?");
            var numberOfPlayers = Console.ReadLine();
            Console.WriteLine($"You chose {numberOfPlayers}");
        }
    }
}
