using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone
{
    class TestLogic
    {
        public static IEnumerable<int> Run(string param1)
        {

            int[] numbers = param1.Split(' ').Select(x => int.Parse(x)).ToArray();
            List<NumberedWeight> weights = new List<NumberedWeight>();
            foreach (int i in numbers)
            {
                string numberToString = i.ToString();
                int sum = 0;
                foreach (char n in numberToString)
                {
                    sum += int.Parse(n.ToString());
                }
                weights.Add(new NumberedWeight(i, sum));
            }
            int[] result = weights.OrderByDescending(x => x.ElementCount).OrderBy(y => y.Number).OrderBy(z => z.Weight).Select(y => y.Number).ToArray();
            return result;
        }
        class NumberedWeight
        {
            public NumberedWeight(int number, int weight)
            {
                Number = number;
                Weight = weight;
                ElementCount = number.ToString().Count();
                FirstCharacter = number.ToString()[0];
            }
            public int Number { get; set; }
            public int Weight { get; set; }
            public int ElementCount { get; set; }
            public char FirstCharacter { get; set; }
        }
        public static int Run2(int number)
        {
            int result = 0;
            int counter = 0;
            while (counter < number)
            {
                if (counter % 3 == 0 || counter % 5 == 0)
                {
                    result += counter;
                }
                counter++;
            };
            return result;
        }
        public static bool Braces(string braces)
        {
            if (string.IsNullOrWhiteSpace(braces))
                return false;
            string openBraces = "({[";
            string closeBraces = ")}]";
            List<string> queue = new List<string>();
            foreach(char brace in braces)
            {
                if (openBraces.Contains(brace))
                {
                    queue.Add(brace.ToString());
                }
                if (closeBraces.Contains(brace))
                {
                    string lastItem = queue.Last();
                    if (!openBraces.Contains(lastItem))
                    {
                        return false;                        
                    }
                    int indexOfBrace = closeBraces.IndexOf(brace);
                    int indexOfOpenBrace = openBraces.IndexOf(lastItem);
                    if (indexOfBrace == indexOfOpenBrace)
                    {
                        //Closing Brace Matches Open Brace
                        queue.RemoveAt(queue.Count - 1);
                    }
                    else
                    {
                       
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
