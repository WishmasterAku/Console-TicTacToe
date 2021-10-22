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
     
        public TicTacToeBoard(int row, int col)
        {
            _row = row;
            _col = col;
            position = new char[row, col];

            for (int x = 0; x < row; x++)
            {
                
                for (int y = 0; y < col; y++)
                {

                    position[x, y] = ' ';//replaces the zeros to blank spots
                } 
            }
        }
        public void printGrid()
        {
            //Console.WriteLine("Columns");
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

        