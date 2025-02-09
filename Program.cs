using RockPaperScissors.Interfaces;
using RockPaperScissors.Players;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameIntro();

            HumanPlayer humanPlayer = new HumanPlayer();
            IPlayer? player2 = null;

            switch (PlayerSelection())
            {
                case "C":
                    player2 = new ComputerPlayer();
                    break; 

                case "H":
                    player2 = new HumanPlayer();
                    break;
            }


            ShowGameCommands();

            Game game = new Game(humanPlayer, player2);
            game.play();
            
        }


         static void GameIntro()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("****WELCOME TO ROCK, PAPER, SCISSORS****");
            Console.WriteLine("****************************************\n");
        }

        static string PlayerSelection()
        {
            Console.WriteLine("****Choose A Opponent****");
            Console.WriteLine("C - Computer");
            Console.WriteLine("H - Human\n");

            while (true)
            {
                Console.Write("Choose a player >>> ");
                string option = Console.ReadLine();
                if (option.Equals("C", StringComparison.OrdinalIgnoreCase) ||
                    option.Equals("H", StringComparison.OrdinalIgnoreCase))
                {
                    return option.ToUpper();
                }
            }
        }

        static void ShowGameCommands()
        {
            Console.WriteLine("\nYOU ARE --> Player 1 <--\n");
            Console.WriteLine("Q - Quit");
            Console.WriteLine("S - Scissor");
            Console.WriteLine("P - Paper");
            Console.WriteLine("R - Rock");

            Console.WriteLine("\n****************************************\n");
        }
    }
}
