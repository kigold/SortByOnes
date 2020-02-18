using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

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
            //var res = PublishedTime.TimeDiff(DateTime.Parse("12/12/2018"), DateTime.Now);
            /*var b = new[] { new { a = 1, b = " t1" }, new { a = 2, b = " t2" }, new { a = 1, b = " t1" } };
            var l = b.ToList();
            var u = l.Distinct();
            var z = Convert.ToInt64("45");
            Console.WriteLine(l.Count() +" -" + u.Count());*/
            /*Console.WriteLine("Enter WOrd to be encoded");
            var word = Console.ReadLine();
            var coded = Encoding.Encrypt(word);
            Console.WriteLine($"Encoded: {coded}");
            Console.WriteLine($"Decoded: {Encoding.Decrypt(coded)}");
            List<AppType> apps = new List<AppType>();
            apps.Add(AppType.admin);
            apps.Add(AppType.guest);
            Console.WriteLine(apps);*/
            BiggestTableSln.Start(new[] { "4", "5", "1,1,1,1,1,"});

            Console.ReadLine();
        }

        
    }

    public enum AppType
    {
        user,
        admin,
        guest
    }
}
