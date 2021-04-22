using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone
{
    public class Occurence
    {
        public static string QuestionThree(string StringValue)
        {
            var inputCharArray = StringValue.ToCharArray();
            try
            {
                Dictionary<char, int> dictionary = new Dictionary<char, int>();
                foreach (var character in StringValue)
                {
                    if (dictionary.ContainsKey(character))
                    {
                        dictionary[character] = dictionary[character] + 1;
                    }
                    else
                    {
                        dictionary.Add(character, 1);
                    }
                }

                string output = string.Empty;

                foreach (var item in dictionary)
                {
                    output += item.Key.ToString() + item.Value;
                }

                Console.WriteLine($"Output: {output}");
                return output;
            }
            catch (Exception)
            {
                Console.WriteLine($"An error has occured, please try again.");
            }
            return null;

        }

        public static bool Q1(string inputString)
        {
            //Remove hyphen from string of numbers
            string numbers = inputString.Replace("-", "");

            //convert string of numbers to array starts here

            int[] intArray = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                intArray[i] = int.Parse(numbers[i].ToString());

            }


            // ends here

            //calculating the difference between arrays of numbers from the next element starts here

            int[] intervalDiff = new int[numbers.Length - 1];


            for (int j = 0; j < intervalDiff.Length; j++)
            {

                intervalDiff[j] = intArray[j] - intArray[j + 1];

            }


            //ends here

            //checking if the differrence is the same for all elements starts here using LINQ 

            int result = intervalDiff.Distinct().Take(2).Count();

            bool output = (result == 1) ? true : false;

            return output;
        }
    }
}
