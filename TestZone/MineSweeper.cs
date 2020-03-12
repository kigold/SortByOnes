using System;
using System.Linq;

namespace TestZone
{
    public class MineSweeper
    {
        public static void Solve(string param)
        {
            var parameters = param.Split('\n');
            if (parameters.Count() < 1)
                throw new Exception();

            var dimension = parameters[0].Split(' ');
            int[] dimAsInt = new[] { int.Parse(dimension[0]), int.Parse(dimension[1]) };

            string[,] board = new string[dimAsInt[0], dimAsInt[1]];

            int paramPointer = 0;

            for (int i = 0; i < dimAsInt[0]; i++)
            {
                paramPointer++;
                string[] line = parameters[paramPointer].Split(' ');
                for (int j = 0; j < dimAsInt[1]; j++)
                {
                    board[i, j] = line[j];
                }
            }

            var result = Solution(board, dimAsInt[0], dimAsInt[1]);
            int c = 0;
            foreach(var r in result)
            {
                Console.Write(r);
                Console.Write(" ");
                c++;
                if (c % 4 == 0)
                    Console.WriteLine();
            }

        }

        public static string[,] Solution(string[,] board, int row, int col)
        {

            //Get each cell
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //Get the number of mines around each cell
                    int numberOfMines = 0;
                    if (board[i, j] == "*")
                        continue;
                    //'TODO correct get surrrounding Cells
                    for (int k = 0; k < col; k++)
                    {
                        if (i - k < 0 || k + i > col)
                        {
                            continue;
                        }
                        if (board[i - k, k] == "*")
                        {
                            numberOfMines++;
                        }
                    }
                    board[i, j] = numberOfMines.ToString();
                }
            }

            return board;

        }
    }
}

