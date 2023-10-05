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
        Player myPlayer = new Player(1);

        public CheckForWin()
        {
            gameOver = false;

        }

        private static bool gameOver;

        public bool GameOver
        {

            get
            {

                if (!gameOver)
                {

                    Console.Clear();
                    Board.GetBoardLayout();
                    Console.WriteLine($"Spelare {myPlayer.GetPlayer} har vunnit");


                }
                else if (IsBoardFull())
                {
                    Console.Clear();
                    Board.GetBoardLayout();
                    Console.WriteLine("det är ovagjort");
                    gameOver = true;
                }
                return gameOver;
            }
        }



        public void CheckForWins()

        {

            //for (int i = 0; i < 3; i++)
            //{
            //    if (Board.GetBoardLayout()[i * 3] == Board.GetBoardLayout()[i * 3 + 1] && Board.GetBoardLayout()[i * 3 + 1] == Board.GetBoardLayout()[i * 3 + 2])
            //        gameOver = true;

            //    if (Board.GetBoardLayout()[i] == Board.GetBoardLayout()[i + 3] && Board.GetBoardLayout()[i + 3] == Board.GetBoardLayout()[i + 6])
            //        gameOver = true;
            //}
            //if (Board.GetBoardLayout()[0] == Board.GetBoardLayout()[4] && Board.GetBoardLayout()[4] == Board.GetBoardLayout()[8])
            //    gameOver = true;

            //if (Board.GetBoardLayout()[2] == Board.GetBoardLayout()[4] && Board.GetBoardLayout()[4] == Board.GetBoardLayout()[6])
            //    gameOver = true;


            for (int i = 0; i < 3; i++)
            {
                if (Board.GetBoardLayout()[i] == Board.GetBoardLayout()[i +1] && Board.GetBoardLayout()[i+ 1] == Board.GetBoardLayout()[i + 2])
                    gameOver = true;

                if (Board.GetBoardLayout()[i] == Board.GetBoardLayout()[i + 3] && Board.GetBoardLayout()[i + 3] == Board.GetBoardLayout()[i + 6])
                    gameOver = true;
            }
            if (Board.GetBoardLayout()[0] == Board.GetBoardLayout()[4] && Board.GetBoardLayout()[4] == Board.GetBoardLayout()[8])
                gameOver = true;

            if (Board.GetBoardLayout()[2] == Board.GetBoardLayout()[4] && Board.GetBoardLayout()[4] == Board.GetBoardLayout()[6])
                gameOver = true;



            gameOver = false;
        }



        //public bool CheckForWins()

        //{

        //    for (int i = 0; i < 3; i++)
        //    {
        //        if (myBoard._board[i * 3] == myBoard._board[i * 3 + 1] && myBoard._board[i * 3 + 1] == myBoard._board[i * 3 + 2])
        //            return true;

        //        if (myBoard._board[i] == myBoard._board[i + 3] && myBoard._board[i + 3] == myBoard._board[i + 6])
        //            return true;
        //    }
        //    if (myBoard._board[0] == myBoard._board[4] && myBoard._board[4] == myBoard._board[8])
        //        return true;

        //    if (myBoard._board[2] == myBoard._board[4] && myBoard._board[4] == myBoard._board[6])
        //        return true;


        //    return false;
        //}

        public bool IsBoardFull()
        {


            foreach (char c in Board.GetBoardLayout())
            {
                if (c != 'X' && c != 'O')
                    return false;
            }
            return true;
        }

    }



}




//char[] board = myBoard.GetBoardLayout();

//private Board myBoard = new Board();



//static bool CheckForWin()
// Kolla rader, kolumner och diagonaler
//for (int i = 0; i < 3; i++)
//{
////    if (board[i * 3] == board[i * 3 + 1] && board[i * 3 + 1] == board[i * 3 + 2] && board[i * 3] != ' ')
////        return true;
////    if (board[i] == board[i + 3] && board[i + 3] == board[i + 6] && board[i] != ' ')
////        return true;
////}
////if (board[0] == board[4] && board[4] == board[8] && board[0] != ' ')
////    return true;
////if (board[2] == board[4] && board[4] == board[6] && board[2] != ' ')
////    return true;

////return false;////    if (board[i * 3] == board[i * 3 + 1] && board[i * 3 + 1] == board[i * 3 + 2] && board[i * 3] != ' ')
////        return true;
////    if (board[i] == board[i + 3] && board[i + 3] == board[i + 6] && board[i] != ' ')
////        return true;
////}
////if (board[0] == board[4] && board[4] == board[8] && board[0] != ' ')
////    return true;
////if (board[2] == board[4] && board[4] == board[6] && board[2] != ' ')
////    return true;

////return false;
