using System;

namespace Console_TicTacToe
{
    class Program
    {
        static bool gameInSession = true;
        static bool playerOneTurnToMove = true;
        static bool playerWon = false;
        static string playerOne;
        static string playerTwo;
        static char[,] spots = {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' },
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Player 1 please enter your name");
            playerOne = Console.ReadLine();
            Console.WriteLine("Player 2 please enter your name");
            playerTwo = Console.ReadLine();
         
            GameInSession();
        }

        static void TicTacToeLayout()
        {

            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", spots[0, 0], spots[0, 1], spots[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", spots[1, 0], spots[1, 1], spots[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", spots[2, 0], spots[2, 1], spots[2, 2]);
            Console.WriteLine("     |     |     ");
        }
        public static void PlayerTurn(char selection, char playerMove)
        {
            switch (selection)
            {
                case '1':
                    spots[0, 0] = playerMove;
                    break;
                case '2':
                    spots[0, 1] = playerMove;
                    break;
                case '3':
                    spots[0, 2] = playerMove;
                    break;
                case '4':
                    spots[1, 0] = playerMove;
                    break;
                case '5':
                    spots[1, 1] = playerMove;
                    break;
                case '6':
                    spots[1, 2] = playerMove;
                    break;
                case '7':
                    spots[2, 0] = playerMove;
                    break;
                case '8':
                    spots[2, 1] = playerMove;
                    break;
                case '9':
                    spots[2, 2] = playerMove;
                    break;
            }
        }

        public static void GameInSession()
        {
            while (gameInSession == true)
            {
                if (playerOneTurnToMove == true)
                {
                    Console.WriteLine($""+playerOne+" Make your move");
                    TicTacToeLayout();
                    char playerOneMove = Convert.ToChar(Console.ReadLine());

                    PlayerTurn(playerOneMove, 'X');
                    PlayerOneGameWinner();
                    if(playerWon == true)
                    {
                        PlayerOneWon();
                    }
                    playerOneTurnToMove = false;
                    Console.Clear();
                    
                }
                else
                {
                    Console.WriteLine($"" + playerTwo + " Make your move");
                    TicTacToeLayout();
                    char playerTwoMove = Convert.ToChar(Console.ReadLine());

                    PlayerTurn(playerTwoMove, 'O');
                    PlayerTwoGameWinner();
                    if (playerWon == true)
                    {
                        PlayerTwoWon();
                    }
                    playerOneTurnToMove = true;
                    Console.Clear();
                }
            }
        }

        public static void PlayerOneGameWinner()
        {

            //Horizontal
            if (spots[0, 0] == 'X' && spots[0, 1] == 'X' && spots[0, 2] == 'X')
            {
                playerWon = true;
            }
            else if (spots[1, 0] == 'X' && spots[1, 1] == 'X' && spots[1, 2] == 'X')
            {
                playerWon = true;
            }
            else if (spots[2, 0] == 'X' && spots[2, 1] == 'X' && spots[2, 2] == 'X')
            {
                playerWon = true;
            }

            //Vertical
            if (spots[0, 0] == 'X' && spots[1, 0] == 'X' && spots[2, 0] == 'X')
            {
                playerWon = true;
            }
            else if (spots[0, 1] == 'X' && spots[1, 1] == 'X' && spots[2, 1] == 'X')
            {
                playerWon = true;
            }
            else if (spots[0, 2] == 'X' && spots[1, 2] == 'X' && spots[2, 2] == 'X')
            {
                playerWon = true;
            }

            //Diagonal
            if (spots[0, 0] == 'X' && spots[1, 1] == 'X' && spots[2, 2] == 'X')
            {
                playerWon = true;
            }
            else if (spots[0, 2] == 'X' && spots[1, 1] == 'X' && spots[2, 0] == 'X')
            {
                playerWon = true;
            }
            return;

        }
        public static void PlayerOneWon()
        {
            Console.Clear();
            TicTacToeLayout();
            Console.WriteLine($"Congratulations "+playerOne+"!");
            gameInSession = false;
            Console.ReadLine();
        }

        public static void PlayerTwoGameWinner()
        {
            //Horizontal
            if (spots[0, 0] == 'O' && spots[0, 1] == 'O' && spots[0, 2] == 'O')
            {
                playerWon = true;
            }
            else if (spots[1, 0] == 'O' && spots[1, 1] == 'O' && spots[1, 2] == 'O')
            {
                playerWon = true;
            }
            else if (spots[2, 0] == 'O' && spots[2, 1] == 'O' && spots[2, 2] == 'O')
            {
                playerWon = true;
            }

            //Vertical
            if (spots[0, 0] == 'O' && spots[1, 0] == 'O' && spots[2, 0] == 'O')
            {
                playerWon = true;
            }
            else if (spots[0, 1] == 'O' && spots[1, 1] == 'O' && spots[2, 1] == 'O')
            {
                playerWon = true;
            }
            else if (spots[0, 2] == 'O' && spots[1, 2] == 'O' && spots[2, 2] == 'O')
            {
                playerWon = true;
            }

            //Diagonal
            if (spots[0, 0] == 'O' && spots[1, 1] == 'O' && spots[2, 2] == 'O')
            {
                playerWon = true;
            }
            else if (spots[0, 2] == '0' && spots[1, 1] == '0' && spots[2, 0] == '0')
            {
                playerWon = true;
            }
            return;

        }
        public static void PlayerTwoWon()
        {
            Console.Clear();
            TicTacToeLayout();
            Console.WriteLine($"Congratulations " + playerTwo + "!");
            gameInSession = false;
            Console.ReadLine();
        }
    }
}


