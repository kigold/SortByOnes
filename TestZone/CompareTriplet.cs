using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone
{
    public class CompareTriplet
    {
        public static List<int> Compare(List<int>a, List<int>b)
        {
            var result = new List<int> { 0, 0 };
            for (int i = 0; i < 3; i++)
            {
                if (a[i] == b[i])
                    continue;
                if (a[i] > b[i])
                    result[0]++;
                else
                    result[1]++;
            }
            return result;
        }
        public static void GetParams()
        {
            Console.WriteLine("Enter values for Alice");
            var alice = Console.ReadLine();
            var temp_a = alice.Split(' ');
            var a = temp_a.Select(x => int.Parse(x)).ToList();
            a.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Enter values for BOb");
            var bob = Console.ReadLine();
            var temp_b = bob.Split(' ');
            var b = temp_b.Select(x => int.Parse(x)).ToList();
            b.ForEach(x => Console.WriteLine(x));
            var res = Compare(a, b);
            res.ForEach(x => Console.WriteLine(x));
        }
    }
}
