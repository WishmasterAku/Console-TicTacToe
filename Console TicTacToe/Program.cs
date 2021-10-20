using System;
using System.Linq;

namespace Console_TicTacToe
{
    class Program
    {
        static bool gameInSession = true;
        static bool playerOneTurnToMove = true;
        static bool playerWon = false;
        static bool validInput = false;
        static string playerOne;
        static string playerTwo;
        
        static int customRow = 6;
        static int customCol = 6;
        //static int x = 1;
        static char[] customSpots;     
        static char[,] spots = {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' },
        };
        static void MainOnHold(string[] args)
        {
            
            Console.WriteLine("Welcome to Xander's Tic Tac Toe Game!"); 
            Console.WriteLine("Player 1 please enter your name");
            playerOne = Console.ReadLine();
            Console.WriteLine("Player 2 please enter your name");
            playerTwo = Console.ReadLine();
            Console.WriteLine("Would you like to play a Classic Game or Custom Game?");
            Console.WriteLine("Press 1 for Classic and 2 for Custom");
            int typeOfGame = Int32.Parse(Console.ReadLine());
            if(typeOfGame == 1)                                       
                GameInSession();           
            else
                CustomGame();
            //spot.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            
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
        
        

        public static void PlayerOneGameWinnerCustom()
        {

            int x = 1;
            int winCondition = 1; // radius
            

            //int[] vertical = new int[customRow];
            //Array.Fill(vertical, 0);

            for (int row = 0; row < customRow; row++)
            {
                //int hortizonal = 0;

                for (int col = 0; col < customCol; col++)
                {
                    char value = customSpots[x];

                    if(value == 'X')
                    {
                        //hortizonal += 1;
                        //vertical[col] += 1;

                        bool isComplete = true;
                        // left and right
                        for(int c = col- winCondition; c < col+winCondition; ++c)
                        {
                            int r = row;

                            char localValue = getValue(r, c);

                            if(localValue != 'X')
                            {
                                isComplete = false;
                            }

                        }

                        if (isComplete)
                        {
                            playerWon = true;
                        }
                        isComplete = true;
                        // up and down
                        for (int r = row - winCondition; r < row + winCondition; ++r)
                        {
                            int c = col;

                            char localValue = getValue(r, c);

                            if (localValue != 'X')
                            {
                                isComplete = false;
                            }

                        }

                        if (isComplete)
                        {
                            playerWon = true;
                        }
                        isComplete = true;
                        // top left to bottom right
                        for (int r = row - winCondition; r < row + winCondition; ++r)
                        {
                            for (int c = col - winCondition; c < col + winCondition; ++c)
                            {

                                char localValue = getValue(r, c);

                                if (localValue != 'X')
                                {
                                    isComplete = false;
                                }
                            }
                        }
                        if (isComplete)
                        {
                            playerWon = true;
                        }
                        isComplete = true;

                        // bottom left to bottom right
                        for (int r = row + winCondition; r > row - winCondition; --r)
                        {
                            for (int c = col - winCondition; c < col + winCondition; ++c)
                            {

                                char localValue = getValue(r, c);

                                if (localValue != 'X')
                                {
                                    isComplete = false;
                                }
                            }
                        }




                        if (isComplete)
                        {
                            playerWon = true;
                        }




                    }
                    //else
                    //{
                    //    //hortizonal = 0;
                    //    //vertical[col] = 0;
                    //}

                    //if (hortizonal == 3 || vertical[col] == 3)
                    //{
                    //    playerWon = true;
                    //}


                    x++;
                }
                
            }


        }


        public static char getValue(int r, int c)
        {

            if(r < 0 || r >= customRow)
            {
                return '1';
            }

            if (c < 0 || c >= customCol)
            {
                return '1';
            }

            int coordinate = c + (r * customCol);

            char value = customSpots[coordinate];

            return value;


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
        public static void CustomGame()
        {

            Console.WriteLine("How many Rows? (Number between 3 and 9)");
            customRow = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many Columns? (Number between 3 and 9)");
            customCol = Int32.Parse(Console.ReadLine());


            if ((customRow < 3 || customRow > 9) && (customCol < 3 || customCol > 9))
            {
                Console.WriteLine("Invalid Choices");
            }
            else
            {
                CustomGameInSession();
            }                   
          
        }
        public static void CustomBoardLayout()
        {
            int[] customSpots = Enumerable.Range(0, 100).ToArray();

            customSpots[10] = Convert.ToChar('X'); //Testing inserting predetermined value
                Console.WriteLine();
                for (int row = 0; row < customRow; row++)
                {
                    Console.Write("|  ");
                    for (int col = 0; col < customCol; col++)
                    {
                        Console.Write(customSpots[x].ToString("D2"));
                        Console.Write("  |  ");
                        x++;
                    }
                    Console.WriteLine();                
                }

            Console.ReadLine();  

        }
        public static void CustomGameInSession()
        {
            while (gameInSession == true)
            {
                if (playerOneTurnToMove == true)
                {
                    Console.WriteLine($"" + playerOne + " Make your move");
                    CustomBoardLayout();
                    char playerOneMove = Convert.ToChar(Console.ReadLine()); //Need to convert new table to char array?

                    PlayerTurn(playerOneMove, 'X');// need to fix this to new custom player move
                    PlayerOneGameWinner();
                    if (playerWon == true)
                    {
                        PlayerOneWon();
                    }
                    playerOneTurnToMove = false;
                    Console.Clear();

                }
                else
                {
                    Console.WriteLine($"" + playerTwo + " Make your move");
                    CustomBoardLayout();
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
    }
}


