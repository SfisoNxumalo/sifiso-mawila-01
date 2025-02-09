using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;
using RockPaperScissors.Interfaces;

namespace RockPaperScissors.Players
{

    /// <summary>
    /// Class that represents a human player
    /// </summary>
    public class HumanPlayer : IPlayer
    {
        public Choices PickChoice()
        {

            while (true)
            {
                Console.Write("Enter your option >>> ");
                string option = Console.ReadLine();

                if (option.Equals("Q", StringComparison.OrdinalIgnoreCase) ||
                    option.Equals("R", StringComparison.OrdinalIgnoreCase) ||
                    option.Equals("P", StringComparison.OrdinalIgnoreCase) ||
                    option.Equals("S", StringComparison.OrdinalIgnoreCase))
                {
                    switch (option.ToUpper())
                    {
                        case "Q":
                            return Choices.QUIT;
                        case "S":
                            return Choices.SCISSOR;
                        case "P":
                            return Choices.PAPER;
                        case "R":
                            return Choices.ROCK;
                        default:
                            return Choices.QUIT;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Selection, enter Q, R, P or S\n");
                }
            }
        }
    }
}
