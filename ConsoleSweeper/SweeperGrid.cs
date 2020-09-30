using System;

namespace ConsoleSweeper
{
    public class SweeperGrid
    {
        
        Random generator = new Random();
        
        public int[,] board = new int[10, 10];

        

        public SweeperGrid()
        {
            for (int y = 0; y < board.GetLength(1); y++)
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    
                    board[x, y] = 9;

                }
            }

            for (int i = 0; i < 10; i++)
            {
                
                int y = generator.Next(0, 10);
                int x = generator.Next(0, 10);

                while (board[x, y] == 10)
                {
                    y = generator.Next(0, 10);
                    x = generator.Next(0, 10);

                }

                board[x, y] = 10;

            }

            // for (int y = 0; y < board.GetLength(1); y++)
            // {
            //     for (int x = 0; x < board.GetLength(0); x++)
            //     {
            //         Console.Write(board[x, y] + " ");
            //     }
            //     Console.WriteLine();
            // }
        }



        public bool CheckPosition()
        {
            
            Console.WriteLine("X Value (0-9):");
            string answerx = Console.ReadLine();

            Console.WriteLine("Y Value (0-9):");
            string answery = Console.ReadLine();


            Console.ReadLine();

            int coordsx = int.Parse(answerx);
            int coordsy = int.Parse(answery);

            while (coordsx > 9 && coordsx < 0)
            {
                Console.WriteLine("X Value (0-9):");
                answerx = Console.ReadLine();
            }
        }
    }
}
