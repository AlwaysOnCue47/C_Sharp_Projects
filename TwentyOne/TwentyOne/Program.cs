using System;
using System.Collections.Generic;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Virtual Casino. Enter your name:");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money would you like to play with?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hell, {0}. Would you like to play Twenty One?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "y")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }

                game -= player;
                Console.WriteLine("Thank you for playing.");

            }
            Console.WriteLine("Come back sometime.");
        }
    }
}
