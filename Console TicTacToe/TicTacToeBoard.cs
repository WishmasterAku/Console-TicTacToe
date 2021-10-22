using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_TicTacToe
{
    class TicTacToeBoard
    {
        private int _row;
        private int _col;
        private char[,] position;
        //private int _rowPos;
        //private int _colPos;
        //private bool _playersTurn;
        //private char _playerSign = 'X';


        public TicTacToeBoard(int row, int col)
        {
            _row = row;
            _col = col;
            position = new char[row, col];

            for (int x = 0; x < row; x++)
            {
                
                for (int y = 0; y < col; y++)
                {

                    position[x, y] = ' ';
                } 
            }
        }
        public void printGrid()
        {
            Console.Write(" ");
            for (int i = 0; i <= _col * 4; ++i)
            {
                Console.Write("-");
            }
            Console.WriteLine("");

            for (int x = 0; x < _row; x++)
            {




                for (int y = 0; y < _col; y++)
                {
                    Console.Write(" | ");
                    Console.Write(position[x, y]);
                }

                Console.Write(" | ");
                Console.WriteLine("");
            }
            Console.Write(" ");
            for (int i = 0; i <= _col * 4; ++i)
            {
                Console.Write("-");
            }
        }

        public bool PlayerMove(Player currentPlayer, int rowPosition, int colPosition)
        {

            //_playerSign = playerSign;
            //_rowPos = rowPosition;
            //_colPos = colPosition;

            if (position[rowPosition, colPosition] == ' ')
            {
                position[rowPosition, colPosition] = currentPlayer.GetPlayerSign();
                return true;
            }
            else
            {
                return false;
            }

        }

    }//CLASS
}//NAMESPACE

        //public static void ClassicLayout()
        //{

        //    int[] position = Enumerable.Range(0, 100).ToArray();

        //    int x = 1;
        //    for (int row = 0; row < 3; row++)
        //    {
        //        Console.Write("|  ");
        //        for (int col = 0; col < 3; col++)
        //        {
        //            Console.Write(position[x].ToString("D2"));
        //            Console.Write("  |  ");
        //            x++;
        //        }
        //        Console.WriteLine();

        //    }

        //}
        //public static void CustomLayout()
        //{
        //}
 
