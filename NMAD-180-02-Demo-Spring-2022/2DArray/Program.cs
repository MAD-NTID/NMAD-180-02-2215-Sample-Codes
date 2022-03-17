using System;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ROW = 3;
            const int COL = 3;


            const string X = "X";
            const string O = "O";
            string[,] board = {
                { X, O, O},
                {O,X,X},
                {X,O,X }
            };

            //show the board
            for(int row = 0; row< ROW; row++)
            {
                for(int col = 0; col < COL; col++)
                    Console.Write($"{board[row,col]} ");

                Console.WriteLine();
            }

            //check rows for win
            for(int row = 0; row< ROW; row++)
            {
                int countX = 0;
                int countO = 0;
                for(int col = 0; col < COL; col++)
                {
                    if (board[row, col] == X)
                        countX++;
                    else
                        countO++;
                }

                if(countX == 3)
                {
                    Console.WriteLine("Row figured this out");
                    Console.WriteLine("Player X win");
                    break;
                } else if(countO==3)
                {
                    Console.WriteLine("Row figured this out");
                    Console.WriteLine("Player O win");
                    break;
                }
            }

            //check column win
            for(int col = 0; col < COL; col++)
            {
                int countX = 0;
                int countO = 0;
                for (int row = 0; row < ROW; row++)
                {
                    if (board[row, col] == X)
                        countX++;
                    else
                        countO++;
                }

                if (countX == 3)
                {
                    Console.WriteLine("Col figured this out");
                    Console.WriteLine("Player X win");
                    break;
                }
                else if (countO == 3)
                {
                    Console.WriteLine("Col figured this out");
                    Console.WriteLine("Player O win");
                    break;
                }
            }

            //diagonal#1 win
            for (int row = 0; row < ROW; row++)
            {
                int countX = 0;
                int countO = 0;
                for (int col = 0; col < COL; col++)
                {
                    if (row == col)
                    {
                        if (board[row, col] == X)
                            countX++;
                        else
                            countO++;
                    }

                }

                if (countX == 3)
                {
                    Console.WriteLine("dig#1 figured this out");
                    Console.WriteLine("Player X win");
                    break;
                }
                else if (countO == 3)
                {
                    Console.WriteLine("dig#1 figured this out");
                    Console.WriteLine("Player O win");
                    break;
                }
            }

            int row1 = 0;
            int col1 = COL - 1;
            int countX1 = 0;
            int countY = 0;

            while(col1 >=0 && row1 <ROW)
            {
                if (board[row1, col1] == X)
                    countX1++;
                else
                    countY++;

                if (countX1 == 3)
                {
                    Console.WriteLine("dig#2 figured this out");
                    Console.WriteLine("Player X win");
                    break;
                }
                else if (countY == 3)
                {
                    Console.WriteLine("dig#2 figured this out");
                    Console.WriteLine("Player O win");
                    break;
                }

                col1--;
                row1++;
            }


        }
    }
}
