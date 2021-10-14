using System;

namespace Console_TicTacToe
{
    class Program
    {
        static char[,] spots = {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' },
        };
        //static string[] spots = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static void Main(string[] args)
        {
            bool gameInSession = true;

            while (gameInSession == true)
            {
                Console.WriteLine("Select a spot");
                TicTacToeLayout();
                char playerOneMove = Convert.ToChar(Console.ReadLine());

                PlayerTurn(playerOneMove, 'X');
                Console.Clear();
            }
            //Console.WriteLine("Player 1 please enter your name");
            //var playerOne = Console.ReadLine();
            //Console.WriteLine("Player 1 please enter your name");
            //var playerTwo = Console.ReadLine();
            //bool playMode = true;
            //Console.WriteLine($"" + playerOne + " Please select your move");

            //while (playMode == true)
            //{
            //    Console.WriteLine("Select");
            //    TicTacToeLayout();
            //    var playerOneMove = Int32.Parse(Console.ReadLine().ToString());
            //    spots[playerOneMove] = "O";

            //    Console.WriteLine("Select");
            //    TicTacToeLayout();
            //    var playerTwoMove = Int32.Parse(Console.ReadLine().ToString());
            //    spots[playerOneMove] = "X";

            Console.ReadLine();
        }
            //var result = Array.Find(spots, element => element.Equals(playerOneMove));      
        static void TicTacToeLayout()
        {

            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", spots[0,0], spots[0,1], spots[0,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", spots[1,0], spots[1,1], spots[1,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", spots[2,0], spots[2,1], spots[2,2]);
            Console.WriteLine("     |     |     ");
        }
        public static void PlayerTurn(char selection, char playerMove)
        {
            switch(selection)
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
    }
}

