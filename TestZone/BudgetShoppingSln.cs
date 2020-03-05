using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace TestZone
{
    /*public class BudgetShoppingSln
    {
        public static int budgetShopping(int n, List<int> bundleQuantities, List<int> bundleCosts)
        {
            int result = 0;
            if (bundleQuantities.Count == 0)
            {
                return result;
            }
            int budget = n;

            for (int i = 0; i < bundleQuantities.Count; i++)
            {

                int qty = budget / bundleCosts[i];
                Console.WriteLine(qty);
                int cost = bundleCosts[i] * qty;
                if ((budget - cost) >= 0)
                {
                    budget -= (cost);
                    result += (bundleQuantities[i] * qty);
                }
                while(budget > 0){
                    continue;

                Console.WriteLine("continue");
                }
                break;
                Console.WriteLine("break");

            }

            return result;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int bundleQuantitiesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> bundleQuantities = new List<int>();

            for (int i = 0; i < bundleQuantitiesCount; i++)
            {
                int bundleQuantitiesItem = Convert.ToInt32(Console.ReadLine().Trim());
                bundleQuantities.Add(bundleQuantitiesItem);
            }

            int bundleCostsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> bundleCosts = new List<int>();

            for (int i = 0; i < bundleCostsCount; i++)
            {
                int bundleCostsItem = Convert.ToInt32(Console.ReadLine().Trim());
                bundleCosts.Add(bundleCostsItem);
            }

            int result = Result.budgetShopping(n, bundleQuantities, bundleCosts);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
*/
}