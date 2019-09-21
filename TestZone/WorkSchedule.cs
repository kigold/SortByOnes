using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone
{
    class WorkSchedule
    {
        public static List<string> Run(int workHours, int dayHours, string pattern)
        {
            List<string> output = new List<string>();
            List<string> result = new List<string>();
            foreach (var day in pattern)
            {
                output.Add(day.ToString());
            }
            int variableDays = pattern.Count(x => x == '?');
            if (variableDays > 0)
            {
                int remainingWorkHours = workHours - output.Sum(x => int.Parse(x != "?" ? x : "0"));
                int variableFullDays = remainingWorkHours / dayHours;
                int remainingHours = remainingWorkHours % dayHours;

                int[] array = new int[variableDays];
                for(int j = 0; j < variableDays; j++)
                {
                    for (int i = 0; i <= dayHours; i++)
                    {
                        array[j] = i;
                        if (array.Sum() == remainingWorkHours)
                            result = HeapPermutation.Run(array.Select(x => x.ToString()).ToArray(), result);                        
                    }                    
                }
            }
            //return output.OrderBy(q => q).ToList();
            return PrepareOutput(result, pattern);
        }
        private static List<string> PrepareOutput(List<string> result, string pattern)
        {
            for(int j = 0; j < result.Count(); j++)
            {
                int k = 0;
                string week = "";
                result[j] = result[j].Replace(",", "");
                for(int i=0; i<pattern.Length; i++)
                {
                    if(pattern[i] == '?')
                    {
                        week += result[j][k];
                        k++;
                    }
                    else
                    {
                        week += pattern[i];
                    }
                }
                result[j] = week;                
            }
            return result;
        }
    }
}
