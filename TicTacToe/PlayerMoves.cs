using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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


        public bool PlayerMove()
        {
            int choice;
            do
            {

                //Console.Clear();
                Board.GetBoardLayout();
                _correctInput = true;
                Console.Write($"                                       Spelare {Player._player} välj en plats för din bricka: ");
                _correctInput = int.TryParse(Console.ReadLine(), out choice);
                //Console.Clear();

                if (choice < 1 || choice > 9 || Board.board[choice - 1] == 'X' || Board.board[choice - 1] == 'O')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n                           Ogiltigt val, välj ett tal mellan 1 och 9 och en ruta som inte är upptagen.");
                    Console.WriteLine("\n                           Tryck Enter för att försöka igen.");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                    _correctInput = false;
                }
            } while (!_correctInput);
            if (Player._player == 1)
            {
                Board.board[choice - 1] = 'X';
            }
            else
            {
                Board.board[choice - 1] = 'O';

            }


            myCheck.CheckForWins();
            myCheck.IsBoardFull();
            return _correctInput;

        }

    }

}



