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
    /// Class that represents a computer player
    /// </summary>
    public class ComputerPlayer : IPlayer
    {
        Random rnd = new Random();
        public Choices PickChoice()
        {

            int option = rnd.Next(0, 3);

            switch (option)
            {
                case 0:
                    return Choices.ROCK;
                case 1:
                    return Choices.PAPER;
                case 2:
                    return Choices.SCISSOR;
                default:
                    return Choices.SCISSOR;
            }
        }
    }
}
