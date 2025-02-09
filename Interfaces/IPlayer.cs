using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;

namespace RockPaperScissors.Interfaces
{
    public interface IPlayer
    {

        /// <summary>
        /// Method that initiates the logic for a player to pick an option
        /// </summary>
        /// <returns>An enum item</returns>
        public Choices PickChoice();
    }
}
