using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone
{
    public class MergeString
    {
        public static string mergeStrings(string s1, string s2)
        {
            
            int n = s1.Length;
            n = n * 2;
            if (n == 0)
                return "";
            int i1 = 0;
            int i2 = 0;
            string merged = "";
            for (int i = 0; i < n; i++)
            {
                if (i1 >= n / 2)
                {
                    merged += s2.Substring(i2);
                    return merged;
                }
                if (i2 >= n / 2)
                {
                    merged += s1.Substring(i1);
                    return merged;
                }
                var a = s1[i1];
                var b = s2[i2];
                if (a < b)
                {
                    merged += s1[i1];
                    i1++;
                }
                else
                {
                    merged += s2[i2];
                    i2++;
                }
            }
            return merged;
        }

    }
}
