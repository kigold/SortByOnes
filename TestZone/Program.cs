using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone
{
    class Program
    {
        static void Main(string[] args)
        {

            /*string[] input = Console.ReadLine().Split(',');
            int[] myInts = Array.ConvertAll(input, s => int.Parse(s));
            string[] t = new[] { "1", "2" };
            Console.WriteLine(string.Join(",", Rearrange.rearrange(myInts)));
            int[] res = Rearrange.rearrange(myInts);*/
            //var client = new ConsoleClient();
            //client.GetToken().Wait();
            //client.QueryApi().Wait();
            /*var res = TestLogic.Run("56 65 74 100 99 68 86 180 90");
            foreach (var i in res)
                Console.Write(i + " ");
            Console.WriteLine(TestLogic.Braces("     "));*/
            /*Console.WriteLine(CardsWar.Run("A586QK", "JJ653K"));
            Console.WriteLine(CardsWar.Run("23A84Q", "K2Q25J"));*/
            //Console.WriteLine(DivideAndSubtract.Run("011100"));
            /*var res = WorkSchedule.Run(3, 2, "??2??00");
            var res = WorkSchedule.Run(56, 8, "???8???");
            foreach (var i in res)
                Console.WriteLine(i + " ");
            //HeapPermutation.Run("1234");*/
            //APIQuery.Run("1-January-2000", "22-February-2000", "Monday");
            var res = PublishedTime.TimeDiff(DateTime.Parse("12/12/2018"), DateTime.Now);
            Console.WriteLine(res);
            Console.ReadLine();
        }

        
    }
}
