using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone
{
    public class HackCity
    {
        private int _nodeSum{ get; set; }
        public HackCity(int node)
        {
            _nodeSum = node;
        }
        public void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            var aList = Console.ReadLine();
            var t = aList.Split(' ');
            var A = aList.Split(' ').Select(x => int.Parse(x)).ToArray();
            Console.WriteLine($"Result: {Solution(n, A)}");
        }

        public int Solution(int n, int[] A)
        {
            foreach(var i in A)
            {
                var t = (4 * n * i) + 2;
                //sum the edge for all node
                sumNodes(t);
            }
            var result = _nodeSum % 1000000007;
            return result;
        }

        public int sumNodes(int n)
        {
            if (n == 1)
                return 0;
            
            _nodeSum += n;
            return sumNodes(n - 1);
        }
    }
}
