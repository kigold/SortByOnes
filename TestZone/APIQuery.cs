using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading;

namespace TestZone
{
    class APIQuery
    {
        public static void Run(string firstDate, string lastDate, string weekDay)
        {
            HttpClient client = new HttpClient();
            int page = 1;
            string url = @"https://jsonmock.hackerrank.com/api/stocks/";
            HttpResponseMessage response = null;

            CallAPI(client, response, url, page, firstDate, lastDate, weekDay);
        }

        private static void CallAPI(HttpClient client, HttpResponseMessage response, 
            string url, int page, string firstDate, string lastDate, string weekDay)
        {
            Stock result = null;
            response = client.GetAsync(url + "?page=" + page).Result;
            if (response.IsSuccessStatusCode)
                result = ProcessResponse(response);
            if (result == null)
                throw new NullReferenceException("No valid data received from Api");

            List<DateTime> datesRanges = GetDatesInDateRange(firstDate, lastDate, weekDay).ToList();
            //Display results
            var outputs = result.Data.Where(x => datesRanges.Contains(x.Date))
                .Select(item => string.Format("{0} {1} {2}", item.Date.ToString("dd-MMMM-yyyy"), item.Open, item.Close))
                .ToArray();
            foreach (var item in outputs)
                Console.WriteLine(item);

            page = int.Parse(result.Page);
            var getLastItem = result.Data[result.Data.Count - 1];
            DateTime lastDateTime = DateTime.Parse(lastDate);
            //Check if data contains the date lower limit
            if (lastDateTime > getLastItem.Date)
            {
                //increase page number and get more data
                if (page < result.Total_pages)
                {
                    page++;
                    CallAPI(client, response, url, page, firstDate, lastDate, weekDay);
                }

            }
        }

        private static DateTime[] GetDatesInDateRange(string firstDate, string lastDate, string weekDay)
        {
            var fd = DateTime.Parse(firstDate);
            var ld = DateTime.Parse(lastDate);
            List<DateTime> dateRange = new List<DateTime>();
            foreach(var day in EachDay(fd, ld))
            {
                if (day.DayOfWeek.ToString() == weekDay)
                    dateRange.Add(day);
            }
            return dateRange.ToArray();
        }

        private static Stock ProcessResponse(HttpResponseMessage response)
        {
            string rawData = response.Content.ReadAsStringAsync().Result;
            Stock result = JsonConvert.DeserializeObject<Stock>(rawData);
            return result;
        }
        public static IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }
    }
    class Stock
    {
        [JsonProperty("page")]
        public string Page { get; set; }
        public int Per_page { get; set; }
        public int Total { get; set; }
        public int Total_pages { get; set; }
        [JsonProperty("data")]
        public List<StockData> Data { get; set; }

    }
    class StockData
    {
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
    }
}
