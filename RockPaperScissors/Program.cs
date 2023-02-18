namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerInput;
            string botInput = null;
            int randomNumber = new Random().Next(1, 3);

            Console.WriteLine("Select your input (Rock, Paper, Scissors): ");
            playerInput= Console.ReadLine();

            switch(randomNumber)
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
    
            if(playerInput == botInput)
            {
                Console.WriteLine("Bot: " + botInput);
                Console.WriteLine("Draw");
            }
            else if((playerInput == "Rock" && botInput == "Scissors") || (playerInput == "Scissors" && botInput == "Paper") || (playerInput == "Paper" && botInput == "Rock"))
            {
                Console.WriteLine("Bot: " + botInput);
                Console.WriteLine("You won");
            }
            else
            {
                Console.WriteLine("Bot: " + botInput);
                Console.WriteLine("You lost");
            }
        }
    }
}