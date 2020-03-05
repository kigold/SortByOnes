using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone
{
    public class MinMaxSum
    {
        public static void Solution(int[] arrTemp)
        {
            long[] arr = arrTemp.Select(x => (long)x).ToArray();
            var length = arr.Count();
            arr.ToList().ForEach(x => Console.WriteLine(x));
            Array.Sort(arr);
            arr.ToList().ForEach(x => Console.WriteLine(x));
            var t = arr[0] + arr[1] + arr[2] + arr[3] + arr[4];
            var sum = arr.Sum();
            var min =  sum - arr[length-1];
            Int64 max = sum - arr[0];
            Console.WriteLine($"{min} {max}");
        }

        public static void Solve()
        {
            Console.WriteLine("Enter values");
            var t = Console.ReadLine();
            var temp = t.Split(' ');
            int[] p = temp.Select(x => int.Parse(x)).ToArray();
            Solution(p);
        }
    }
}
