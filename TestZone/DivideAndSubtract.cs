using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone
{
    public class DivideAndSubtract
    {
        public static int Run(string S)
        {
            int count = 0;
            int V = Convert.ToInt32(S, 2);
            while(V > 0)
            {
                if (IsEven(V))
                {
                    V /= 2;
                }
                else
                {
                    V -= 1;
                }
                count++;
            }
            return count;
        }
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
                return true;
            return false;
               
        }
    }
}
