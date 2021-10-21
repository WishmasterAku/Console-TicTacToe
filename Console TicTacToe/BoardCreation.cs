using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_TicTacToe
{
    class BoardCreation
    {

        public static void ClassicLayout()
        {

            int[] position = Enumerable.Range(0, 100).ToArray();

            int x = 1;
            for (int row = 0; row < 3; row++)
            {
                Console.Write("|  ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(position[x].ToString("D2"));
                    Console.Write("  |  ");
                    x++;
                }
                Console.WriteLine();

            }

        }
        public static void CustomLayout()
        {
        }
    }
}
