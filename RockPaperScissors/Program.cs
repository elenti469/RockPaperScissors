namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock-Paper-Scissors - Best of five");

            Game game = new Game();
            
            for (int i = 0 ; i < 5; i++) 
            {
                game.game();
                Console.WriteLine("-----------------------------");
            }

            if(game.playerWinCount > game.botWinCount)
            {
                Console.WriteLine("You won!");
                Console.WriteLine("Player: " + game.playerWinCount);
                Console.WriteLine("Bot: " + game.botWinCount);
            }
            else if (game.playerWinCount == game.botWinCount) 
            {
                Console.WriteLine("It's a draw.");
                Console.WriteLine("Player: " + game.playerWinCount);
                Console.WriteLine("Bot: " + game.botWinCount);
            }
            else 
            {
                Console.WriteLine("You lost");
                Console.WriteLine("Player: " + game.playerWinCount);
                Console.WriteLine("Bot: " + game.botWinCount);
            }
        }
    }
}