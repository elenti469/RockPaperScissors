using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Game
    {
        string playerInput;
        string botInput = null;
        int randomNumber = new Random().Next(1, 3);
        public int playerWinCount = 0;
        public int botWinCount = 0;

        public void game()
        {

            Console.WriteLine("Select your input (Rock, Paper, Scissors): ");
            playerInput = Console.ReadLine();

            switch (randomNumber)
            {
                case 1:
                    botInput = "Rock";
                    break;
                case 2:
                    botInput = "Paper";
                    break;
                case 3:
                    botInput = "Scissors";
                    break;
            }

            if (playerInput == botInput)
            {
                Console.WriteLine("Bot: " + botInput);
                Console.WriteLine("Round draw");
            }
            else if ((playerInput == "Rock" && botInput == "Scissors") || (playerInput == "Scissors" && botInput == "Paper") || (playerInput == "Paper" && botInput == "Rock"))
            {
                Console.WriteLine("Bot: " + botInput);
                Console.WriteLine("Round won");
                playerWinCount++;
            }
            else
            {
                Console.WriteLine("Bot: " + botInput);
                Console.WriteLine("Round lost");
                botWinCount++;
            }
        }
    }
}
