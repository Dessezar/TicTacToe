﻿using System.Numerics;

namespace TicTacToe
{

    internal class Program
    {


        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            //Console.WriteLine("  ______________________         ______________________             ______________________                 ");
            //Console.WriteLine(" |                      |       |                      |           |                      |                ");
            //Console.WriteLine(" |________      ________|       |________      ________|           |________      ________|                ");
            //Console.WriteLine("          |    |                         |    |                             |    |                         ");
            //Console.WriteLine("          |    |                         |    |                             |    |                         ");
            //Console.WriteLine("          |    |    ____       ____      |    |     ______        ____      |    |      ___         ___    ");
            //Console.WriteLine("          |    |   |    |     |    |     |    |    |  __  |      |    |     |    |     |   |       |   |   ");
            //Console.WriteLine("          |    |   |    |    |  |   |    |    |   |__|  |  |    |  |   |    |    |    |  |  |     |  |  |  ");
            //Console.WriteLine("          |    |   |    |   |  | |___|   |    |     ____|  |   |  | |___|   |    |   |  | |  |   |  |_|__| ");
            //Console.WriteLine("          |    |   |    |   |  |  ___    |    |    |  __   |   |  |  ___    |    |   |  | |  |   | |   __  ");
            //Console.WriteLine("          |    |   |    |   |  | |   |   |    |   |  |  |  |   |  | |   |   |    |   |  | |  |   |  | |  | ");
            //Console.WriteLine("          |    |   |    |    |  |   |    |    |   |  |__|  |    |  |   |    |    |    |  |  |     |  |  |  ");
            //Console.WriteLine("          |____|   |____|     |____|     |____|    |______|      |____|     |____|     |___|       |___|   ");

            CheckForWin myCheck = new CheckForWin();

            PlayerMoves myMoves = new PlayerMoves(true);

            while (true)
            {

                do
                {
                    myCheck.GameOver = false;
                    myCheck.BoardFull = false;
                    //Player.GetPlayer();
                    //Console.Clear();
                    Player.NextPlayer();
                    myMoves.PlayerMove();

                }
                while (!myCheck.GameOver && !myCheck.BoardFull); // Lägg till villkoret för fullt bräde

                //try
                //{
                Console.WriteLine("                    Spelet är över, vill du avsluta tryck \"N\" annars tryck valfri knapp för att spela igen");
                string playAgainInput = Console.ReadLine().ToLower();

                if (playAgainInput == "n")
                {
                    break;
                }
                else
                {


                    Board.ResetBoard();
                    Player.SetPlayer(2);
                    //Player.NextPlayer();
                }

                //}
                //catch (FormatException)
                //{
                //    Console.WriteLine("fel inmatning");
                //    Console.WriteLine("spelet är över, vill du spela igen? ( J/N )");
                //}
            }






            /*
             * om tid finns, kunna flytta cursur med pilar, och göra en snygg border. 

            GAME STATE GLÖM INTE

             * klasser:

             * player 
                 player 1
                 ska kunna skriva endast ett X
                 try catch för felhantering. 

             * player 2
                 ska kunna skriva endast ett O
                 try catch för felhantering. 

             * board 
                 array 1-9 OK!!!!!!!!!!!!!!
                 design OK!!!!!!!!!!!!!!!!!
                 Spelplanen bör vara array antingen matrix eller en med 9 index (array of char, ' ') OK!!!!!!!!!!!

                 inte lägga i en ruta som redan har något i sig med if sats?
                 while loop för att få spela igen.
                 for loop med plauer 1 contra 2 som turas om. (fel spelare kan inte ta sin tur. ) (kanske egen klass?) var counter++  if var % 0 player 1 else player 2



             * wincontition
                enum för pågående/win/draw. 
                if X array[1][2][3] x enumb(win)
                else if O array[1][2][3] O enumb(win)
                else draw
                pågående if array[i].lenght null 


            public static void WinCondition()
            {
            if (options[0] == options[1] && options[1] == options[2])
            {
                Playing = false;
                if(turn % 2 == 0)
                {
                    Console.WriteLine("Congrats on winning player 1, better luck next time player 2");

             * static klass scoreboard hur många har player 1 vunnit osv.
             */

        }
    }
}
























