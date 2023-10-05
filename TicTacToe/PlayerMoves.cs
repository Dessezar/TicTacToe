using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class PlayerMoves //valde ett namn som inte riktigt stämmer överens med upplägget av klasser och metoder vi valt att använda. 
    {
        public PlayerMoves(bool correctInput)
        {
            _correctInput = correctInput;
        }


        
        private bool _correctInput = false;

        CheckForWin myCheck = new CheckForWin();
        CheckForWin myGameOver = new CheckForWin();

        private Player myPlayer = new Player(1);
        public bool PlayerMove()
        {
            int choice;
            do
            {
                Board.GetBoardLayout();
                _correctInput = true;
                Console.WriteLine($"\nSpelare {myPlayer.GetPlayer()} välj en plats för din bricka");
                _correctInput = int.TryParse(Console.ReadLine(), out choice);
                if (choice < 1 || choice > 9 || Board.GetBoardLayout()[choice - 1] == 'X' || Board.GetBoardLayout()[choice - 1] == 'O')
                {
                    Console.WriteLine("Ogiltigt val, välj en ruta som inte är upptagen.");
                    _correctInput = false;
                }
            } while (!_correctInput);

            if (myPlayer.GetPlayer() == 1)
            {
                Board.GetBoardLayout()[choice - 1] = 'X';
            }
            else
            {
                Board.GetBoardLayout()[choice - 1] = 'O';

            }
            myPlayer.NextPlayer();

            myCheck.CheckForWins();
            myCheck.IsBoardFull();


            return _correctInput;
        }

    }
}


