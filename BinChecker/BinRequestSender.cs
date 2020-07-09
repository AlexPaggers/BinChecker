using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace BinChecker
{
    static class BinRequestSender
    {
        public static async Task<String> SendRequestAsync(DateTime startPeriod)
        {
            DateTime endPeriod = startPeriod.AddDays(14);
            string requestString = $"https://www.peterborough.gov.uk/api/jobs" +
                $"/{startPeriod.Year}-{startPeriod.Month}-{startPeriod.Day}" +
                $"/{endPeriod.Year}-{endPeriod.Month}-{endPeriod.Day}/10008049364";

            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(requestString);
                var resultStream = result.Content.ReadAsStringAsync().Result;

                return resultStream;
            }
        }
    }
}
