using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;
using RockPaperScissors.Interfaces;

namespace RockPaperScissors
{
    public class Game
    {
        private readonly IPlayer _player1;
        private readonly IPlayer _player2;

        public Game() { }

        //Dependency Injection
        public Game(IPlayer _player1, IPlayer _player2) { 
            this._player1 = _player1;
            this._player2 = _player2;
        }

        public void play()
        {
            while (true)
            {
                Choices player1Choice = _player1.PickChoice();
                
                if (player1Choice == Choices.QUIT) {
                    Console.WriteLine("Thank you for playing!!");
                    return;
                }

                Choices player2Choice = _player2.PickChoice();

                ShowPlayerChoices(player1Choice, player2Choice);

                DetermineWinner(player1Choice, player2Choice);
            }
            
        }

        private static void ShowPlayerChoices(Choices player1Choice, Choices player2Choice)
        {
            Console.WriteLine($"Player 1 picked --> {player1Choice}");
            Console.WriteLine($"Player 2 picked --> {player2Choice}");
        }
        
        private static void DetermineWinner(Choices player1Choice, Choices player2Choice)
        {
            Console.WriteLine("******************");
            if (player1Choice == player2Choice)
            {
                Console.WriteLine("DRAWWW!!!");
            }
            else if (player1Choice == Choices.ROCK && player2Choice == Choices.SCISSOR)
            {
                Console.WriteLine("Player 1 Wins!!!!");
            }
            else if (player1Choice == Choices.PAPER && player2Choice == Choices.ROCK)
            {
                Console.WriteLine("Player 1 Wins!!!!");
            }
            else if (player1Choice == Choices.SCISSOR && player2Choice == Choices.PAPER)
            {
                Console.WriteLine("Player 1 Wins!!!!");
                
            }
            else
            {
                Console.WriteLine("Player 2 Wins!!!!");
            }
            Console.WriteLine("******************\n");
        }

    }
}
