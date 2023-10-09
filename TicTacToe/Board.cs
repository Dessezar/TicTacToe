using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    static class Board
    {

        public static char[] board = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static void GetBoardLayout()
        {
            Console.Clear();
            Console.WriteLine("  ______________________         ______________________             ______________________                  ");
            Console.WriteLine(" |                      |       |                      |           |                      |                 ");
            Console.WriteLine(" |________      ________|       |________      ________|           |________      ________|                 ");
            Console.WriteLine("          |    |                         |    |                             |    |                          ");
            Console.WriteLine("          |    |                         |    |                             |    |                          ");
            Console.WriteLine("          |    |    ____       ____      |    |     ______        ____      |    |      ___         ___     ");
            Console.WriteLine("          |    |   |    |     |    |     |    |    |  __  |      |    |     |    |     |   |       |   |    ");
            Console.WriteLine("          |    |   |    |    |  |   |    |    |   |__|  |  |    |  |   |    |    |    |  |  |     |  |  |   ");
            Console.WriteLine("          |    |   |    |   |  | |___|   |    |     ____|  |   |  | |___|   |    |   |  | |  |   |  |_|__|  ");
            Console.WriteLine("          |    |   |    |   |  |  ___    |    |    |  __   |   |  |  ___    |    |   |  | |  |   | |   __   ");
            Console.WriteLine("          |    |   |    |   |  | |   |   |    |   |  |  |  |   |  | |   |   |    |   |  | |  |   |  | |  |  ");
            Console.WriteLine("          |    |   |    |    |  |   |    |    |   |  |__|  |    |  |   |    |    |    |  |  |     |  |  |   ");
            Console.WriteLine("          |____|   |____|     |____|     |____|    |______|      |____|     |____|     |___|       |___|    ");
            Console.WriteLine("                                                                                                          ©");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine($"                                                       {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("                                                      ----------");
            Console.WriteLine($"                                                       {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("                                                      ----------");
            Console.WriteLine($"                                                       {board[6]} | {board[7]} | {board[8]} \n");
        }
        public static void ResetBoard()
        {
            Console.Clear();
            for (int i = 0; i < 9; i++)
            {


                Board.board[i] = (i + 1).ToString()[0];
            }
        }
    }
}
