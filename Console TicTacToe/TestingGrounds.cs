using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_TicTacToe
{
    class TestingGrounds
    {
        static int customRow = 6;
        static int customCol = 6;
        static int x = 1;
        static char[] customSpots;
        static void Main(string[] args)
        {
            CustomBoardLayout();
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
            /*while (gameInSession == true)
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
            }*/
        }
    }
}
