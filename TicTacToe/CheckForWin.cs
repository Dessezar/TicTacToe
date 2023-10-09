using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe;

namespace TicTacToe
{
    public class CheckForWin
    {

        public CheckForWin()
        {
            gameOver = false;
            boardFull = false;
        }

        private static bool gameOver;

        public bool GameOver
        {
            get
            {
                if (gameOver)
                {

                    //Console.Clear();
                    Board.GetBoardLayout();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"                                                 Spelare {Player._player} har vunnit");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                }
                return gameOver;
            }
            set { gameOver = value; }
        }

        private static bool boardFull;

        public bool BoardFull
        {
            get
            {
                if (boardFull)
                {
                    Console.Clear();
                    Board.GetBoardLayout();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("                                                   Det är ovagjort");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    gameOver = true;
                }
                return boardFull;
            }
            set { boardFull = value; }
        }

        public void CheckForWins()
        {

            for (int i = 0; i < 3; i++)

            {
                if (Board.board[i * 3] == Board.board[i * 3 + 1] && Board.board[i * 3 + 1] == Board.board[i * 3 + 2])
                    gameOver = true;

                if (Board.board[i] == Board.board[i + 3] && Board.board[i + 3] == Board.board[i + 6])
                    gameOver = true;
            }
            if (Board.board[0] == Board.board[4] && Board.board[4] == Board.board[8])
                gameOver = true;

            if (Board.board[2] == Board.board[4] && Board.board[4] == Board.board[6])
                gameOver = true;
        }


        public void IsBoardFull()
        {
            if (!Board.board.Any(char.IsNumber))
            {
                boardFull = true;
            }

            //    foreach (char c in Board.board)
            //{
            //boardFull = true;
            //    if (c != 'X' && c != 'O')
            //        boardFull = false;
            //    return;
            //}
        }

    }



}
