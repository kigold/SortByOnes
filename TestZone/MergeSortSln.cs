using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone
{
    public class MergeSortSln
    {
        public static int[] Sort(int[] a)
        {
            MergeSort(a, 0, a.Length - 1);
            Console.WriteLine(string.Join(",", a));
            return a;
        }

        private static void MergeSort(int[] a, int l, int r)
        {
            if(l < r)
            {
                // Same as (l+ r)/ 2, but avoids overflow for
                // large l and h 
                int m = l + (r - l) / 2;

                // Sort first and second halves 
                MergeSort(a, l, m);
                MergeSort(a, m + 1, r);

                Merge(a, l, m, r);
            }
        }

        // Merges two subarrays of arr[]. 
        // First subarray is arr[l..m] 
        // Second subarray is arr[m+1..r] 
        private static void Merge (int[] a, int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;

            /* create temp arrays */
            int[] L = new int[n1];
            int[] R = new int[n2];

            for (i = 0; i < n1; i++)
                L[i] = a[l + i];
            for (j = 0; j < n2; j++)
                R[j] = a[m + 1 + j];

            /* Merge the temp arrays back into arr[l..r]*/
            i = 0; // Initial index of first subarray 
            j = 0; // Initial index of second subarray 
            k = l; // Initial index of merged subarray 

            while(i < n1 && j < n2)
            {
                if(L[i] <= R[j])
                {
                    a[k] = L[i];
                    i++;
                }
                else
                {
                    a[k] = R[j];
                    j++;
                }
                k++;
            }

            /* Copy the remaining elements of L[], if there are any */
            while(i < n1)
            {
                a[k] = L[i];
                i++;
                k++;
            }
            /* Copy the remaining elements of R[], if there are any */
            while (j < n2)
            {
                a[k] = R[j];
                j++;
                k++;
            }
        }
    }
}
