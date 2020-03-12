using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone
{
    public class BirthdayCakeCandle
    {
        public static int Solution(int[] array)
        {
            if (array.Length < 1)
                return 0;
            int max = array[0];
            int count = 1;
            for(int i = 1; i < array.Length; i++)
            {
                if(max < array[i])
                {
                    count = 1;
                    max = array[i];
                }
                else if(max == array[i])
                {
                    count++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(count);
            return count;
        }

        public static void Solve()
        {
            var para = new int[] { 3, 2, 1, 3 };
            Solution(para);
        }
    }
}
