using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone
{
    public class BiggestTableSln
    {
        /*
         * 4
            5
            11110
            11010
            11000
            00000
         
             */
        public static int BiggestTable(char[][] grid)
        {
            //Your code here
            int R = grid.Length;
            int C = grid.FirstOrDefault().Length;
            char[] temp_array = grid.FirstOrDefault();
            int result = maxHistogram(R, C, temp_array);
            for(int i = 1; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        grid[i][j] += grid[i - 1][j];
                    }
                }
                result = Math.Max(result, maxHistogram(R, C, grid[i]));
            }
            return result;
        }

        public static int maxHistogram(int R, int C, char[] array)
        {
            Stack<int> result = new Stack<int>();
            int top;
            int max_area = 0;
            int area = 0;
            int i = 0;
            while(i < C)
            {
                if(result.Count == 0 || array[result.Peek()] <= array[i])
                {
                    result.Push(i++);
                }
                else
                {
                    top = array[result.Peek()];
                    result.Pop();
                    area = top * 1;

                    if(result.Count > 0)
                    {
                        area = top * (i - result.Peek() - 1);
                    }
                    max_area = Math.Max(area, max_area);
                }
            }
            while (result.Count > 0)
            {
                top = array[result.Peek()];
                result.Pop();
                area = top * i;
                if (result.Count > 0)
                {
                    area = top * (i - result.Peek() - 1);
                }

                max_area = Math.Max(area, max_area);
            }
            return max_area;
        }

        public static void Start(string[] args)
        {
            var matrix = GetMatrix();
            var bigTable = BiggestTable(matrix);
            Console.WriteLine(bigTable);
        }

        public static char[][] GetMatrix()
        {
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());

            char[][] matrix = new char[rows][];
            for (var i = 0; i < rows; i++)
            {
                var line = Console.ReadLine();
                matrix[i] = line.ToCharArray();
            }

            return matrix;
        }
    }
}
