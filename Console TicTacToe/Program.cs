using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_TicTacToe
{
    class Program
    {

        //==========================================================================================
        public static int Main(string[] arg)
        {
            bool gameInSession = true;            

            List<Player> players = new List<Player>();
            
            Console.WriteLine("Welcome to Xander's Tic Tac Toe Game");
            //PlayerOne
            Console.WriteLine("Player One Please enter your name");
            string playerOneName = Console.ReadLine().ToString();
            Player playerOne = new Player(playerOneName, 'X', 0);
            players.Add(playerOne);
            //PlayerTwo
            Console.WriteLine("Player Two Please enter your name");
            string playerTwoName = Console.ReadLine().ToString();
            Player playerTwo = new Player(playerTwoName, 'O', 0);
            players.Add(playerTwo);

            while (true)
            {

                Console.WriteLine("Would you like to play Classic TicTacToe Game or Custom?");
                Console.WriteLine("Press 1 for Classic Game and 2 for Custom Game,"+
                    " or type 'exit'.");

                String consoleInput = Console.ReadLine();

                int typeOfGame = Int32.Parse(consoleInput);

                if (typeOfGame == 1)
                {
                    TicTacToeBoard ticTacToeBoard = new TicTacToeBoard(players, 3, 3);

                    ticTacToeBoard.PlayGame();



                }

                if (typeOfGame == 2)
                {

                    Console.WriteLine("not yet implented...Please return later");

                }

                if(consoleInput.Equals("exit", StringComparison.InvariantCultureIgnoreCase))
                {
                    return 0; // exits the function, and as its main this exits the program
                }


            }

            return 0; // traditional to return an int from main
               
        }// end of main
        //==========================================================================================



    }//class
}//namespace


