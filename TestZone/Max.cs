using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone
{
    public static class Max
    {
        public static int GetMax(int[] A)
        {
            //return A.Max();
            int max = A[0];
            foreach(int i in A)
            {
                if (max < i && i.ToString().Length == 1)
                {
                    max = i;
                }
            }
            return max;
        }
    }
}
