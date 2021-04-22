using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using TestZone.DataStructures;
using System.Collections.Specialized;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

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
            //BiggestTableSln.Start(new[] { "4", "5", "1,1,1,1,1,"});

            /*string[] words =
            { "the", "fox", "jumps", "over", "the", "dog", "jumps" };
            LinkedList<string> L = new LinkedList<string>(words);

            var result = LinkedListSoln.FindLoop(L);/


            /*
            var Heap = new BinaryHeap();
            string command = "";
            while(command.ToLower() != "exit")
            {
                Console.WriteLine("Enter ur desired command such as INSERT, REMOVE, SORT, PRINT");
                command = Console.ReadLine();
                switch (command.ToLower())
                {
                    case "i":
                        {
                            Console.WriteLine("Enter item to insert");
                            int.TryParse(Console.ReadLine(), out int item);
                            Heap.Insert(item);
                            break;
                        }
                    case "r":
                        {
                            Console.WriteLine("Enter item to remove");
                            int.TryParse(Console.ReadLine(), out int item);
                            Heap.Remove(item);
                            break;
                        }
                    case "s":
                        {
                            Heap.Sort();
                            Heap.PrintItems();
                            break;
                        }
                    default:
                        {
                            Heap.PrintItems();
                            break;
                        }
                }
            }
            */
            //CompareTriplet.GetParams();
            // MinMaxSum.Solve();
            /*var users = new List<User>
           {
               new User("Kingsley", 31),
               new User("Cele", 21)
           };
            users.ForEach((x) => { Console.WriteLine(x); });*/
            /*string param = "3 4\n* 0 0 0\n0 * 0 *\n0 0 0 0";
            MineSweeper.Solve(param);*/
            //BirthdayCakeCandle.Solve();
            /*var HC = new HackCity(0);
            HC.Solve();
            var t = "Kingsley & sons inc";
            var v = t.Split(' ');
            var r = v.Select(x => x[0]);
            var result = string.Join("", r);
            Console.WriteLine(result.ToUpper());*/
            /*for (int i = 0; i < 20; i++)
                Console.WriteLine(RandomGen.RandomString(10));*/
            /*Console.WriteLine(Max.GetMax(new[] { 4, 3, 8, 3, 5, 7, 9, 45, 45, 58, 25 }));
            Console.WriteLine(Max.GetMax(new[] { -6, -91, 1011, -100, 84, -22, 0, 1, 473 }));*/
            //Console.WriteLine(MergeString.mergeStrings("super", "tower"));
            //Console.WriteLine(MergeSortSln.Sort(new[] { 4, 3, 8, 3, 5, 7, 9, 45, 45, 58, 25 }));
            //Console.WriteLine(MergeSortSln.Sort(new[] { -6, -91, 1011, -100, 84, -22, 0, 1, 473 }));
            //Console.WriteLine(MergeSortSln.Sort(new[] { 12, 11, 13, 5, 6, 7 }));

            //var  s = Occurence.QuestionThree("occurrence");
            var s = Occurence.Q1("1-3-5-7-9-11");
            Console.WriteLine(s);

            bool? t = null;
            if (t != null && !t.Value)
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("not ok");
            }
            Console.WriteLine(string.Concat(Enumerable.Repeat("0", 4)));
            Console.WriteLine(ValidateTagNumber("OOER-NIG-LAG-284"));

            Console.WriteLine(GenerateContractId(1, " Ekoh Kingsley"));

            //var outright = new Outright { Id = 1, Outcomes = new List<Outcome>() { new Outcome { Id = 1, Name = "EPL" }, new Outcome { Id = 2, Name = "Laliga" } } };
            var outright = new Outright { Id = 1, Outcomes = new List<Outcome>()};

            foreach(var item in outright.Outcomes)
            {
                item.Name = "Kingsley";
            }

            Console.WriteLine(outright.Outcomes.Select(x => x.Name).FirstOrDefault());

            var res = RepeatedWord.firstRepeatedWord("king sing  king");

            var dico = new Dictionary<string, string> { { "name", "Kingsley" }, { "age", "30" }, {"NATIONAL", "Nigerian" } };
            var data = new MessageData
            {
                Emails = new List<CreateEmailModel> { new CreateEmailModel("Template1", dico), new CreateEmailModel("Template2", dico), new CreateEmailModel("Template0", new Dictionary<string, string> { }) },
                Outcomes = new List<Outcome> { new Outcome { Id = 1, Name = "Success" }, new Outcome { Id = 2, Name = "Progess" } }
            };
            var serializedData = JsonConvert.SerializeObject(data);

            var deserializedData = JsonConvert.DeserializeObject<MessageData>(serializedData);
            var deserializedData2 = JsonConvert.DeserializeObject<MessageData>(serializedData, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver()});

            var providerDico = new Dictionary<string, long> { { "BBR1AA", 11 }, { "BBG1AA", 111 }, };
            var rawData = new { NAME = "kingsley", FirstName = "Kingsley", OTHERNAME = "Ekoh", BRI = 111, BG1 = 11, providerIds = providerDico };

            var serializedRawData = JsonConvert.SerializeObject(rawData, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            var serializedRawData2 = JsonConvert.SerializeObject(rawData, new JsonSerializerSettings { ContractResolver = new CamelCaseExceptDictionaryKeysResolver() });
            

            var deserializedRawData = JsonConvert.DeserializeObject(serializedRawData);
            var deserializedRawData2 = JsonConvert.DeserializeObject(serializedRawData2);


            var D = DateTime.Now;
            var DT = DateTime.UtcNow;
            var day = D.DayOfWeek;

            var providerDico1 = new Dictionary<string, long> { { "BBR1AA", 11 }, { "BBG1AA", 111 }, };
            var providerDico2 = new Dictionary<string, long> { { "BBR1AA", 11 }, { "BBG1AA", 111 }, };

            Console.WriteLine(day);

            var p = MergeStrings("Kingsle", "kc");
            Console.WriteLine(p);

            var tt = "1(2";

            var ttt = tt.Split('|');

            var zz = tt.Replace('|', ' ');

            ttt = null;
            var gg = ttt?.Select(x => x).ToArray();

            var score = null + 1;

            var path = "Users/B31CF6B4-159B-4837-ADE9-3F9DD445A806/Events/{outlookId}";
            var userId = path.Substring(path.IndexOf('/') + 1, 36);
            var outlookId = path.Substring(path.LastIndexOf('/') + 1);

            ReflectionSh.GetClassProps<MultipleReportModel>();
            Console.ReadLine();
        }


        private static string ValidateTagNumber(string tagNumber)
        {
            //Ensures that the length of the TagNumber is 4, if its less, pad it with "0"
            if (tagNumber == null)
                return tagNumber;
            var splitTag = tagNumber.Split('-');
            if (splitTag.Length < 4 || splitTag[3].Length == 4)
                return tagNumber;
            splitTag[3] = string.Concat(Enumerable.Repeat("0", 4 - splitTag[3].Length)) + splitTag[3];
            return string.Join("-", splitTag[3]);
        }

        private static string GenerateContractId(int poIndex, string name)
        {
            var vendorName = name.Trim().Split(' ');
            var vendorInitials = string.Join("", vendorName.Select(x => x[0]));

            if (!string.IsNullOrEmpty(vendorInitials))
                vendorInitials = vendorInitials.ToUpper();

            var contractId = $"{"base"}/{vendorInitials}/{DateTime.Now.Day}/{DateTime.Now.Month}/{poIndex}";
            return contractId;
        }

        private static string MergeStrings(params string[] p)
        {
            return string.Join("; ", p);
        }


    }

    public class Outright 
    { 
        public int Id { get; set; }
        public List<Outcome> Outcomes { get; set; }
    
    }

    public class Outcome
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    public enum AppType
    {
        user,
        admin,
        guest
    }

    public class MessageData
    {
        public List<CreateEmailModel> Emails { get; set; }
        public List<Outcome> Outcomes { get; set; }
    }

    public class CreateEmailModel
    {
        public CreateEmailModel()
        {

        }
        public CreateEmailModel(string templateType, Dictionary<string, string> replacementDictionary)
        {
            EmailTemplateType = templateType;
            ReplacementData = replacementDictionary;
        }

        public string EmailTemplateType { get; set; }
        public Dictionary<string, string> ReplacementData { get; set; }
    }

}
