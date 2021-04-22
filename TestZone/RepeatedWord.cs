using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone
{
    public class RepeatedWord
    {
        public static string firstRepeatedWord(string sentence)
        {
            List<string> first = new List<string> { };
            int value = 0;
            string[] word = sentence.Split(' ');
            for (int i = 0; i < word.Length; i++)
            {
                if (!string.IsNullOrEmpty((word[i])))
                {
                    first.Add((word[i]));
                    if ((i + 1) == word.Length)
                    {
                        return i.ToString();
                    }
                    if (first.Contains((word[i + 1])))
                    {
                        var x = word[i];
                        return x.ToString();
                    }

                    value = i;
                }
            }

            return value.ToString();
        }
    }
}
