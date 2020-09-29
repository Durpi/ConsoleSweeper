using System;

namespace ConsoleSweeper
{
    public class SweeperGrid
    {
        
        Random generator = new Random();
        
        int[,] board = new int[15, 15];

        

        public SweeperGrid()
        {
            for (int y = 0; y < board.GetLength(1); y++)
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    
                    board[x, y] = 9;

                }
            }

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    
                    

                }
            }
        }
    }
}
