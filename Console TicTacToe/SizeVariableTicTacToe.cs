using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_TicTacToe
{
    class SizeVariableTicTacToe : TicTacToeBoard
    {


        int lastMoveRow = -1;
        int lastMoveCol = -1;

        int _winCondition;


        //==========================================================================================
        public SizeVariableTicTacToe(List<Player> players, int col, int row,int winConidition):
            base(players)
        {


            _row = row;
            _col = col;
            _winCondition = winConidition;

            initialiseGrid();



        }// end of SizeVariableTicTacToe constructor
        //==========================================================================================



        //==========================================================================================
        protected override void playerTurn(Player currentPlayer)
        {
            bool validMove = false;
            while (validMove == false)
            {
                Console.Clear();
                this.printGrid();
                Console.WriteLine("");
                Console.WriteLine("{0} please select a Row", currentPlayer.GetPlayerName());
                int rowPosition = Int32.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("{0} please select a Column", currentPlayer.GetPlayerName());
                int colPosition = Int32.Parse(Console.ReadLine()) - 1;
                validMove = base.PlayerMove(currentPlayer, rowPosition, colPosition);

                lastMoveRow = rowPosition;
                lastMoveCol = colPosition;

            }


        }// end of playerTurn
        //==========================================================================================



        //==========================================================================================
        private char getGridData(int rowPosition, int colPosition)
        {

            char returnVal = ' '; // default

            if (rowPosition >= _row || rowPosition < 0 || colPosition >= _col || colPosition < 0)
            {
                return returnVal;
            }

            // otherwise get the actual data from grid

            return position[rowPosition, colPosition];



        }
        //==========================================================================================


        //==========================================================================================
        protected override bool checkPlayerWon(Player currentPlayer)
        {


            // horizontal
            Point currentPoint = new Point(lastMoveCol,lastMoveRow);
            int count = 0;
            for (int i = currentPoint .X- _winCondition; i < currentPoint.X+ _winCondition; ++i)
            {


                char currentValue = getGridData( currentPoint.Y,i);

                if (currentValue == currentPlayer.GetPlayerSign())
                {
                    count += 1;
                }
                else
                {
                    count = 0; // reset count
                }

                if (count == _winCondition)
                {
                    return true;
                }

            }

            //Vertical
            count = 0;
            for (int i = currentPoint.Y - _winCondition; i < currentPoint.Y + _winCondition; ++i)
            {
                char currentValue = getGridData(i, currentPoint.Y);

                if (currentValue == currentPlayer.GetPlayerSign())
                {
                    count += 1;
                }
                else
                {
                    count = 0; // reset count
                }

                if (count == _winCondition)
                {
                    return true;
                }

            }

            //Diagonal bottom left to top right
            count = 0;
            int j = currentPoint.X - _winCondition;
            for (int i = currentPoint.Y - _winCondition; i < currentPoint.Y + _winCondition; ++i)
            {
                char currentValue = getGridData( j,i);

                if (currentValue == currentPlayer.GetPlayerSign())
                {
                    count += 1;
                }
                else
                {
                    count = 0; // reset count
                }

                if (count == _winCondition)
                {
                    return true;
                }
                ++j;
            }


            //Diagonal bottom right to top left
            count = 0;
            j = currentPoint.X + _winCondition;
            for (int i = currentPoint.Y - _winCondition; i < currentPoint.Y + _winCondition; ++i)
            {
                char currentValue = getGridData(j,i);

                if (currentValue == currentPlayer.GetPlayerSign())
                {
                    count += 1;
                }
                else
                {
                    count = 0; // reset count
                }

                if (count == _winCondition)
                {
                    return true;
                }
                --j;
            }


            return false;
        }// end of playerWon
        //==========================================================================================



    }//CLASS
}//NAMESPACE
