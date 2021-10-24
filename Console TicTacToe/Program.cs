using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_TicTacToe
{
    class Program
    {
        public static void Main(string[] arg)
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

            Console.WriteLine("Would you like to play Classic TicTacToe Game or Custom?");
            Console.WriteLine("Press 1 for Classic Game and 2 for Custom Game.");
            int typeOfGame = Int32.Parse(Console.ReadLine());

            if (typeOfGame == 1)
            {
                TicTacToeBoard ticTacToeBoard = new TicTacToeBoard(3, 3);

                while (gameInSession == true)
                {
                    //if (playerOneTurnToMove == true)
                    foreach(Player currentPlayer in players)
                    {
                        Console.Clear();
                        ticTacToeBoard.printGrid();
                        
                        bool validMove = false;
                        bool playerWon = false;
                        while (validMove == false)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("{0} please select a Row", currentPlayer.GetPlayerName());
                            int rowPosition = Int32.Parse(Console.ReadLine())-1;
                            Console.WriteLine("{0} please select a Column", currentPlayer.GetPlayerName());
                            int colPosition = Int32.Parse(Console.ReadLine())-1;
                            validMove = ticTacToeBoard.PlayerMove(currentPlayer, rowPosition, colPosition);
                            playerWon = ticTacToeBoard.PlayerWon(currentPlayer);
                            if (playerWon == true) {
                                Console.Clear();
                                ticTacToeBoard.printGrid();

                                currentPlayer.IncreasedPlayerTotalWins();

                                Console.WriteLine("Congratulations {0}", currentPlayer.GetPlayerName());
                                Console.WriteLine("Scoreboard");
                                Console.WriteLine("{0} {1} | {2} {3}",  playerOne.GetPlayerName(), playerOne.GetPlayerTotalWins(), 
                                                                        playerTwo.GetPlayerName(), playerTwo.GetPlayerTotalWins());
                                Console.ReadLine();
                                gameInSession = false;                                
                            }
                        }
                    }
                }
            }
                if(typeOfGame == 2)
            {
                Console.WriteLine("Please select total Rows. (Between 3-9)");
                int rowPosition = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please select total Columns. (Between 3-9");
                int colPosition = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please enter how many in a row to win. (Between 3-9)");
                int numsToWin = Int32.Parse(Console.ReadLine());
                TicTacToeBoard ticTacToeBoard = new TicTacToeBoard(rowPosition, colPosition);
                ticTacToeBoard.printGrid();
                while (gameInSession == true)
                {                    
                    foreach (Player currentPlayer in players)
                    {
                        Console.Clear();
                        ticTacToeBoard.printGrid();

                        bool validMove = false;
                        bool playerWon = false;
                        while (validMove == false)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("{0} please select a Row", currentPlayer.GetPlayerName());
                            rowPosition = Int32.Parse(Console.ReadLine()) - 1;
                            Console.WriteLine("{0} please select a Column", currentPlayer.GetPlayerName());
                            colPosition = Int32.Parse(Console.ReadLine()) - 1;
                            validMove = ticTacToeBoard.PlayerMove(currentPlayer, rowPosition, colPosition);
                            playerWon = ticTacToeBoard.PlayerWon(currentPlayer);
                            if (playerWon == true)
                            {
                                Console.Clear();
                                ticTacToeBoard.printGrid();

                                currentPlayer.IncreasedPlayerTotalWins();

                                Console.WriteLine("Congratulations {0}", currentPlayer.GetPlayerName());
                                Console.WriteLine("Scoreboard");
                                Console.WriteLine("{0} {1} | {2} {3}", playerOne.GetPlayerName(), playerOne.GetPlayerTotalWins(),
                                                                        playerTwo.GetPlayerName(), playerTwo.GetPlayerTotalWins());
                                Console.ReadLine();
                                gameInSession = false;                                
                            }
                        }
                    }
                }
            }
        }        
    }//class
}//namespace


