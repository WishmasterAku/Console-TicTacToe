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
        private int[,] position; 

        public TicTacToeBoard(int row, int col)
        {
            _row = row;
            _col = col;
            position = new int[row, col];

            for (int x = 0; x < row; x++)
            {
                
                for (int y = 0; y < col; y++)
                {
                    
                    position[x, y] = 0;
                }
            }
        }
        public void printGrid()
        {            
            for (int x = 0; x < _row; x++)                
            {
                Console.Write("|  ");
                for (int y = 0; y < _col; y++)
                {
                    Console.Write(" | ");
                    Console.Write(position[x, y]);
                }
                Console.WriteLine("");
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
 
