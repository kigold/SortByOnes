using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone
{
    class Rearrange
    {
        public static int[] rearrange(int[] elements)
        {

            int n = elements.Count();
            //sort
            int[] OneCounts = new int[n];
            int[] numbers = new int[n];
            for (var i = 0; i < elements.Count(); i++)
            {
                numbers[i] = Convert.ToInt32(elements[i].ToString());
                var temp = elements[i].ToString();
                OneCounts[i] = numberOfOne(Convert.ToString(Convert.ToInt32(temp), 2));
            }
            Array.Sort(numbers, OneCounts);
            Array.Sort(OneCounts, numbers);
            //Console.WriteLine($"numbers = {string.Join(",", numbers)}");
            //Console.WriteLine($"Ones counts = {string.Join(",", OneCounts)}");

            return numbers;

            //METHOD
            int numberOfOne(string number)
            {
                //count number of ones in string of number
                int count = 0;
                foreach (var i in number)
                {
                    if (i == '1') { count++; }
                }
                return count;
            }

        }
    }
}
