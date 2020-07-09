using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinChecker
{
    public static class BinCollectionInfoParser
    {
        public static IEnumerable<BinCollectionInfo> Parse(string jsonResult)
        {
            JObject set = JObject.Parse(jsonResult);
            var jobs = set["jobs_FeatureScheduleDates"].Children();

            List<BinCollectionInfo> infoList = new List<BinCollectionInfo>();
            
            foreach (var job in jobs)
            {
                var newInfo = new BinCollectionInfo(
                    ParseDateTimeFromJson(job.Value<string>("nextDate")),
                    ParseDateTimeFromJson(job.Value<string>("previousDate")),
                    ParseBinType(job.Value<string>("jobName")));

                infoList.Add(newInfo);
            }
            return infoList;
        }

        private static BinType ParseBinType(string jobName)
        {
            switch (jobName)
            {
                case "Empty Bin 240L Green": return BinType.Green;
                case "Empty Bin 240L Black": return BinType.Black;
                default: throw new InvalidOperationException("Unrecognised " + jobName);
            }
        }

        private static DateTime ParseDateTimeFromJson(string dateTimeString)
        {
            return DateTime.ParseExact(dateTimeString, "MM/dd/yyyy HH:mm:ss", null);
        }
    }
}
