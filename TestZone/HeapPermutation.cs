using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone
{
    class HeapPermutation
    {
        public static List<string> Run(string[] array, List<string> result)
        {
            int k = array.Count();
            Permutations(k, array, result);
            //Output(result.Distinct().OrderBy(x => x).ToArray());
            return result.Distinct().OrderBy(x => x).ToList();
        }
        private static void Permutations(int k, string[] list, List<string> result)
        {
            if (k  == 1)
                result.Add(string.Join(",", list));
            else
            {
                Permutations(k - 1, list, result);
                for(int i = 0; i < k-1; i++)
                {
                    //if k is even
                    if(k % 2 == 0)
                        Swap(i, k - 1, list);                  
                    else
                        Swap(0, k - 1, list);
                    Permutations(k - 1, list, result);
                }
            }
        }
        private static void Swap(int a, int b, string[] array)
        {
            string temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
        private static void Output(string[] list)
        {
            foreach (var j in list)
                Console.WriteLine(j + " ");
            Console.WriteLine();        
        }
    }
}
