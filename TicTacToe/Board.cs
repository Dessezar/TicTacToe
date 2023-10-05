using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    static class Board
    {

        static char[] board = new char[] { '1','2','3','4','5','6','7','8','9'};
        public static char[] GetBoardLayout()
        {
            Console.Clear();
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("----------");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("----------");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");

           return board;
        }
    }
}
