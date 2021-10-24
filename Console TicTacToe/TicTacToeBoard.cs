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
            Console.WriteLine("    Columns");     
            Console.Write("  ");
            for (int i = 1; i <= _col; ++i)
            {
                Console.Write("-"+i+"- ");
            }
            Console.WriteLine("");
            Console.Write(" ");
            for (int i = 0; i <= _col * 4; ++i)
            {                
                Console.Write("-");    
            }
            Console.WriteLine("");            
            for (int x = 0; x < _row; x++)
            {
                //Console.Write("    ");
                for (int y = 0; y < _col; y++)
                    //Console.Write("    ");
                {                   
                    Console.Write(" | ");
                    Console.Write(position[x, y]);
                }
                Console.Write(" | ");
                Console.WriteLine("");
            }
            //Console.Write("    ");
            Console.Write(" ");
            for (int i = 0; i <= _col * 4; ++i)
            {
                Console.Write("-");               
            }
            Console.WriteLine("");
        }
        public bool PlayerMove(Player currentPlayer, int rowPosition, int colPosition)
        {
            if ((rowPosition > _row || rowPosition < 0) && ((colPosition > _col || colPosition < 0)))
            {
                return false;
            }
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
        public bool PlayerWon(Player currentPlayer)
        {
            //Horizontal 
            if ((position[0, 0] == currentPlayer.GetPlayerSign()) && 
                (position[0, 1] == currentPlayer.GetPlayerSign()) && 
                (position[0, 2] == currentPlayer.GetPlayerSign()))
            {
                
                return true;
            }
                 if ((position[1, 0] == currentPlayer.GetPlayerSign()) &&
                    (position[1, 1] == currentPlayer.GetPlayerSign()) &&
                    (position[1, 2] == currentPlayer.GetPlayerSign()))
            {
                return true;
            }
                     if (((position[2, 0] == currentPlayer.GetPlayerSign()) &&
                        (position[2, 1] == currentPlayer.GetPlayerSign()) &&
                        (position[2, 2] == currentPlayer.GetPlayerSign())))
            { 
                return true;
            }
            //Vertical
                 if ((position[0, 0] == currentPlayer.GetPlayerSign()) &&
                    (position[1, 0] == currentPlayer.GetPlayerSign()) &&
                    (position[2, 0] == currentPlayer.GetPlayerSign()))
            {
                return true;
            }
                     if ((position[0, 1] == currentPlayer.GetPlayerSign()) &&
                        (position[1, 1] == currentPlayer.GetPlayerSign()) &&
                        (position[2, 1] == currentPlayer.GetPlayerSign()))
            {
                return true;
            }
                         if (((position[0, 2] == currentPlayer.GetPlayerSign()) &&
                            (position[1, 2] == currentPlayer.GetPlayerSign()) &&
                            (position[2, 2] == currentPlayer.GetPlayerSign())))
            {
                return true;
            }
            //Diagonal
                if ((position[0, 0] == currentPlayer.GetPlayerSign()) &&
                    (position[1, 1] == currentPlayer.GetPlayerSign()) &&
                    (position[2, 2] == currentPlayer.GetPlayerSign()))
            {
                return true;
            }
                     if (((position[0, 2] == currentPlayer.GetPlayerSign()) &&
                        (position[1, 1] == currentPlayer.GetPlayerSign()) &&
                        (position[2, 0] == currentPlayer.GetPlayerSign())))
            {
                return true;
            }
            return false;
        }
    }//CLASS
}//NAMESPACE

        